using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;

namespace Spritimator_Tao
{
    class Sprite
    {
        List<AnimSequence> sequences = new List<AnimSequence>();
        string name;
        AnimSequence currentSequence = null;


        public Sprite(string _name)
        {
            name = _name;
        }

        public bool Import(string filename, List<Texture> textures, int framewidth, int frameheight, XmlDocument doc, XmlElement spriteElement)
        {

            name = spriteElement.GetAttribute("Name");

            List<string> texes = new List<string>();

            XmlNodeList texElements = spriteElement.GetElementsByTagName("texture");

            foreach (XmlElement tex in texElements)
            {
                string texname = tex.GetAttribute("File");
                if (File.Exists(texname) == false)
                {
                    string file = System.IO.Path.GetFileName(texname);
                    MessageBox.Show("We had trouble finding " + texname + " could you point us to it?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OpenFileDialog open = new OpenFileDialog();
                    open.CheckFileExists = true;
                    open.Filter = file + "|" + file;

                    DialogResult r = open.ShowDialog();
                    if (r != DialogResult.OK)
                    {
                        throw new FileNotFoundException();
                    }
                    texname = open.FileName;
                }
                texes.Add(texname);
            }

            XmlNodeList seqElements = spriteElement.GetElementsByTagName("sequence");

            foreach (XmlElement seq in seqElements)
            {
                currentSequence = new AnimSequence(seq.GetAttribute("Name"));
                try
                {
                    currentSequence.ReturnLoopFrame = int.Parse(seq.GetAttribute("Return_Loop_Frame"));
                }
                catch (Exception)
                {
                    //MessageBox.Show("Sequence didn't have a return loop frame id");
                }
                try
                {
                    currentSequence.Loops = int.Parse(seq.GetAttribute("Loops")) == 0 ? false : true;
                }
                catch (Exception)
                {
                    currentSequence.Loops = true;
                }
                sequences.Add(currentSequence);

                XmlNodeList frameElements = seq.GetElementsByTagName("frame");

                foreach (XmlElement frameE in frameElements)
                {
                    if (texes.Count == 0)
                    {
                        MessageBox.Show("No textures in xml?");
                        break;
                    }
                    Texture texture = null;
                    int texId = int.Parse(frameE.GetAttribute("Texture"));
                   // MessageBox.Show("Tex id = " + texId.ToString());
                    string texName = texes[texId];
                   // MessageBox.Show("Texture = " + texName);
                    foreach (Texture tex in textures)
                    {
                        if (tex.Filename == texName)
                        {
                            texture = tex;
                            //MessageBox.Show("Texture already loaded");
                            break;
                        }
                    }
                    if (texture == null)
                    {
                        texture = new Texture(texName, framewidth, frameheight);
                        textures.Add(texture);
                        //MessageBox.Show("Texture not loaded.  Loading " + texName);
                    }

                    Frame frame = new Frame(double.Parse(frameE.GetAttribute("Time")), 0, false, false, 1,1, int.Parse(frameE.GetAttribute("Tex_X")),
                        int.Parse(frameE.GetAttribute("Tex_Y")), int.Parse(frameE.GetAttribute("Width")), int.Parse(frameE.GetAttribute("Height")),
                        double.Parse(frameE.GetAttribute("Anchor_X")), double.Parse(frameE.GetAttribute("Anchor_Y")), texture);
                    currentSequence.AddFrame(frame);
                }
            }

            return true;


        }

        public void Export(string filename)
        {

            try
            {
                //pick whatever filename with .xml extension

                XmlDocument xmlDoc = new XmlDocument();

                try
                {
                    xmlDoc.Load(filename);
                }
                catch (System.IO.FileNotFoundException)
                {
                    //if file is not found, create a new xml file
                    XmlTextWriter xmlWriter = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
                    xmlWriter.Formatting = Formatting.Indented;
                    xmlWriter.WriteProcessingInstruction("xml", "version='1.0' encoding='UTF-8'");
                    xmlWriter.WriteStartElement("sprites");
                    //xmlWriter.WriteStartElement("name");
                    //xmlWriter.WriteString(name);
                    //xmlWriter.WriteEndElement();
                    //If WriteProcessingInstruction is used as above,
                    //Do not use WriteEndElement() here
                    //xmlWriter.WriteEndElement();
                    //it will cause the &ltRoot></Root> to be &ltRoot />
                    xmlWriter.Close();
                    xmlDoc.Load(filename);
                }
                XmlNode root = xmlDoc.DocumentElement;


                //XmlAttribute nameAttrib = xmlDoc.CreateAttribute("Name");

                XmlElement spriteElement = xmlDoc.CreateElement("sprite");
                spriteElement.SetAttribute("Name", name);
                root.AppendChild(spriteElement);


                //nameAttrib.Value = name;
                //root.Attributes.Append(nameAttrib);

                List<Texture> textures = new List<Texture>();

                foreach (AnimSequence seq in sequences)
                {
                    foreach (Frame frame in seq.Frames)
                    {
                        if (textures.Contains(frame.Texture) )
                            continue;
                        else
                            textures.Add(frame.Texture);
                    }
                }

                foreach (Texture tex in textures)
                {
                    XmlElement textureElement = xmlDoc.CreateElement("texture");
                    textureElement.SetAttribute("File", tex.Filename);
                    textureElement.SetAttribute("Width", tex.Width.ToString());
                    textureElement.SetAttribute("Height", tex.Height.ToString());
                    spriteElement.AppendChild(textureElement);
                }


                foreach (AnimSequence seq in sequences)
                {
                    XmlElement seqNode = xmlDoc.CreateElement("sequence");
                    seqNode.SetAttribute("Name", seq.Name);
                    //seqNode.SetAttribute("Frames", seq.FrameCount.ToString());
                    seqNode.SetAttribute("Return_Loop_Frame", seq.ReturnLoopFrame.ToString());
                    seqNode.SetAttribute("Loops", (seq.Loops ? 1 : 0).ToString());
                    //XmlElement seqNameE = xmlDoc.CreateElement("name");
                    //seqNode.AppendChild(seqNameE);
                   // XmlText seqName = xmlDoc.CreateTextNode(seq.Name);
                    //seqNameE.AppendChild(seqName);

                    //XmlElement seqCountE = xmlDoc.CreateElement("frame_count");
                   // seqNode.AppendChild(seqCountE);
                    //XmlText seqCount = xmlDoc.CreateTextNode(seq.FrameCount.ToString());
                   // seqCountE.AppendChild(seqCount);

                    foreach (Frame frame in seq.Frames)
                    {
                        XmlElement frameNode = xmlDoc.CreateElement("frame");
                        frameNode.SetAttribute("Time", frame.Time.ToString());
                        frameNode.SetAttribute("Tex_X", frame.XSource.ToString());
                        frameNode.SetAttribute("Tex_Y", frame.YSource.ToString());
                        frameNode.SetAttribute("Width", frame.Width.ToString());
                        frameNode.SetAttribute("Height", frame.Height.ToString());
                        frameNode.SetAttribute("Anchor_X", frame.XAnchor.ToString());
                        frameNode.SetAttribute("Anchor_Y", frame.YAnchor.ToString());
                        frameNode.SetAttribute("Texture", textures.IndexOf(frame.Texture).ToString());


                        seqNode.AppendChild(frameNode);
                    }

                    spriteElement.AppendChild(seqNode);
                }



                xmlDoc.Save(filename);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        public void DeleteCurrentSequence()
        {
            sequences.Remove(currentSequence);
            if (sequences.Count > 0)
                currentSequence = sequences[0];
            else
                currentSequence = null;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddSequence(AnimSequence seq)
        {
            sequences.Add(seq);
            currentSequence = sequences[sequences.Count-1];
        }

        public void SetActiveSequence(int index)
        {
            currentSequence = sequences[index];
        }

        public AnimSequence GetSequence(int index)
        {
            if (index < 0 || index >= sequences.Count)
                return null;
            return sequences[index];
        }

        public AnimSequence GetCurrentSequence()
        {
            return currentSequence;
        }

        public AnimSequence CurrentSequence
        {
            get { return currentSequence; }
        }

        public List<AnimSequence> Sequences
        {
            get
            {
                return sequences;
            }
        }

    }
}
