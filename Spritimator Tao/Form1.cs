using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using Tao.OpenGl;
using Tao.DevIl;
using Tao.Platform.Windows;

namespace Spritimator_Tao
{
    public partial class Form1 : Form
    {
        long start; //start time for animation sequence
        int playingFrame; //current frame to show on screen
        bool playing = false;
        Frame preview = null;

        static Sprite currentSprite = null;
        static Texture currentTexture = null;


        static List<Texture> textures = new List<Texture>();
        static List<Sprite> sprites = new List<Sprite>();

        Point currentMouse = new Point();
        bool mouseDown = false;

        Rectangle sheetViewport;
        Rectangle animViewport;

        public Form1()
        {
            InitializeComponent();
            sheetGLControl.InitializeContexts();

            Il.ilInit();
            Ilu.iluInit();
            Ilut.ilutInit();
            Ilut.ilutEnable(Ilut.ILUT_OPENGL_CONV); 
            Ilut.ilutRenderer(Ilut.ILUT_OPENGL);

            sheetViewport = new Rectangle(0, sheetGLControl.Height - (int)(415.0 / 740.0 * sheetGLControl.Height), (int)(613.0 / 1024.0 * sheetGLControl.Width), (int)(415.0 / 740.0 * sheetGLControl.Height));
            animViewport = new Rectangle((int)(670.0 / 1024.0 * sheetGLControl.Width), sheetGLControl.Height - (int)(280.0 / 740.0 * sheetGLControl.Height) - 10, (int)(300.0 / 1024.0 * sheetGLControl.Width), (int)(280.0 / 740.0 * sheetGLControl.Height));
            currentTexture = new Texture();
        }

        ~Form1()
        {
            sheetGLControl.DestroyContexts();
        }


        private Texture LoadTexture(string filename)
        {
            Texture tex = new Texture(filename, sheetViewport.Width, sheetViewport.Height);
            textures.Add(tex);
            cTextures.Items.Add(filename);
            cTextures.Text = cTextures.Items[cTextures.Items.Count-1].ToString();
            return tex;

        }

        private void MakeTextureActive(Texture texture)
        {
            currentTexture = texture;

            UpdateScrollers();
            hSheetScroll.Value = (int)texture.HOffset;
            vSheetScroll.Value = (int)texture.VOffset;
            tZoom.Value = texture.Zoom;

            sheetGLControl.Draw();
        }

        private void UpdateScrollers()
        {

            int zoom = currentTexture.Zoom;
            int hdiff = currentTexture.HDiff = currentTexture.Width * zoom - sheetViewport.Width;
            int vdiff = currentTexture.VDiff = currentTexture.Height * zoom - sheetViewport.Height;


            if (hdiff > 0)
            {
                hSheetScroll.Maximum = hdiff / zoom + 10;
                if (hSheetScroll.Enabled != true)
                {
                    hSheetScroll.Enabled = true;
                    hSheetScroll.Value = 0;
                    currentTexture.HOffset = 0;
                }
            }
            else
            {
                hSheetScroll.Enabled = false;
                hSheetScroll.Value = 0;
                currentTexture.HOffset = 0;
            }

            if (vdiff > 0)
            {
                vSheetScroll.Maximum = vdiff / zoom + 10;
                if (vSheetScroll.Enabled != true)
                {
                    vSheetScroll.Enabled = true;
                    vSheetScroll.Value = 0;
                    currentTexture.VOffset = 0;
                }

            }
            else
            {
                vSheetScroll.Enabled = false;
                vSheetScroll.Value = 0;
                currentTexture.VOffset = 0;
            }            
        }


        private void simpleOpenGlControl1_Load(object sender, EventArgs e)
        {
            //sheetGLControl.MakeCurrent();

            Gl.glClearColor(240.0f / 255.0f, 240.0f / 255.0f, 240.0f / 255.0f, 0);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_LINEAR);
            Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
            Gl.glDisable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_BLEND);

        }

        private void simpleOpenGlControl1_Paint(object sender, PaintEventArgs e)
        {
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(0, sheetViewport.Width, sheetViewport.Height, 0, 0, 1.0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glViewport(sheetViewport.X, sheetViewport.Y, sheetViewport.Width, sheetViewport.Height);
            //Gl.glViewport(animViewport.X, animViewport.Y, animViewport.Width, animViewport.Height);
            int zoom = currentTexture.Zoom; 

            double cHeight = sheetViewport.Height;
            double cWidth = sheetViewport.Width;

            int realHO = (currentTexture.HOffset);// / cWidth * sheetViewport.Width);
            int realVO = (currentTexture.VOffset);// / cHeight * sheetViewport.Height);

            int realWidth = (currentTexture.Width);// / cWidth * sheetViewport.Width);
            int realHeight = (currentTexture.Height);// / cHeight * sheetViewport.Height);

            realHO *= zoom;
            realVO *= zoom;
            realWidth *= zoom;
            realHeight *= zoom;

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, currentTexture.TextureID);
            //Gl.glColor3f(1.0f, 1.0f, 1.0f);
            Gl.glBegin(Gl.GL_QUADS);

                Gl.glTexCoord2i(0, 0);
                Gl.glVertex2i(-realHO, realHeight - realVO);

                Gl.glTexCoord2i(1, 0);
                Gl.glVertex2i(realWidth - realHO, realHeight - realVO);

                Gl.glTexCoord2i(1, 1);
                Gl.glVertex2i(realWidth - realHO, -realVO);

                Gl.glTexCoord2i(0, 1);
                Gl.glVertex2i(-realHO, -realVO);

            Gl.glEnd();


            Point startMouse = currentTexture.StartMouse;
            Point finishMouse = currentTexture.FinishMouse;
            realHO = ((startMouse.X < finishMouse.X ? startMouse.X : finishMouse.X) - currentTexture.HOffset);// / cWidth * sheetViewport.Width);
            realVO = ((startMouse.Y < finishMouse.Y ? startMouse.Y : finishMouse.Y) - currentTexture.VOffset);// / cHeight * sheetViewport.Height);

            realWidth = (Math.Abs(startMouse.X - finishMouse.X) + 1);// / cWidth * sheetViewport.Width);
            realHeight = (Math.Abs(startMouse.Y - finishMouse.Y) + 1);// / cHeight * sheetViewport.Height);

            realHO *= zoom;
            realVO *= zoom;
            realWidth *= zoom;
            realHeight *= zoom;

            //MessageBox.Show("RHO " + realHO.ToString() + " RVO " + realVO.ToString() + " RW " + realWidth.ToString() + " RH " + realHeight.ToString());

            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);
            Gl.glColor4f(.5f, .5f, .5f, .5f);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex2i(realHO, realHeight + realVO);
            Gl.glVertex2i(realWidth+ realHO, realHeight + realVO);
            Gl.glVertex2i(realWidth + realHO, realVO);
            Gl.glVertex2i(realHO, realVO);
            Gl.glEnd();

            if (cFrameMulti.Checked == true)
            {
                int boxes = int.Parse(tFrameNumber.Text);
                int spacing = int.Parse(tFrameXSpacing.Text);

                Gl.glBegin(Gl.GL_QUADS);
                while (boxes > 0)
                {
                    realHO += spacing + realWidth;
                    if (realHO + realWidth > currentTexture.Width)
                    {
                        realHO = 0;
                        realVO += realHeight;
                    }
                    Gl.glVertex2i(realHO, realHeight + realVO);
                    Gl.glVertex2i(realWidth + realHO, realHeight + realVO);
                    Gl.glVertex2i(realWidth + realHO, realVO);
                    Gl.glVertex2i(realHO, realVO);
                    boxes--;
                }
                Gl.glEnd();
            }

            Gl.glColor3f(1, 1, 1);


            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(-animViewport.Width / 2, animViewport.Width / 2, animViewport.Height / 2, -animViewport.Height / 2, 0, 1.0);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glViewport(animViewport.X, animViewport.Y, animViewport.Width, animViewport.Height);


            if (currentSprite != null && currentSprite.CurrentSequence.FrameCount > 0)
            {
                long now = DateTime.Now.Ticks;
                if (playing && now - start > currentSprite.CurrentSequence.Frames[playingFrame].Time * 10000000)
                {
                    start = now;
                    playingFrame++;
                    if (playingFrame >= currentSprite.CurrentSequence.Frames.Count)
                        if (currentSprite.CurrentSequence.Loops == true)
                            playingFrame = currentSprite.CurrentSequence.ReturnLoopFrame;
                        else
                        {
                            playing = false;
                            playingFrame = 0;
                            return;
                        }
                }
                Frame frame;
                if (preview == null)
                    frame = currentSprite.CurrentSequence.Frames[playingFrame];
                else
                    frame = preview;

                Gl.glPushMatrix();
                if (frame.XScale != 1 || frame.YScale != 1)
                {
                    Gl.glScaled(frame.XScale, frame.YScale, 0);
                    //Gl.glMatrixMode(Gl.GL_PROJECTION);
                    //Gl.glLoadIdentity();
                    //Gl.glOrtho(-animViewport.Width / 2 * frame.XScale, animViewport.Width / 2, animViewport.Height / 2, -animViewport.Height / 2, 0, 1.0);
                    //Gl.glMatrixMode(Gl.GL_MODELVIEW);
                }

                cHeight = animViewport.Height;
                cWidth = animViewport.Width;


                realHO = (int)frame.XAnchor;
                realVO = (int)frame.YAnchor;

                realWidth = (frame.Width);// / cWidth);
                realHeight = (frame.Height);// / cHeight);


                Gl.glBindTexture(Gl.GL_TEXTURE_2D, frame.Texture.TextureID);
                Gl.glBegin(Gl.GL_QUADS);

                float x0, y0, x1, y1;
                x0 = (float)frame.XSource / frame.Texture.Width;
                y0 = 1.0f - (float)frame.YSource / frame.Texture.Height;
                x1 = (float)(frame.XSource + frame.Width) / frame.Texture.Width;
                y1 = 1.0f - (float)(frame.YSource + frame.Height) / frame.Texture.Height;


                Gl.glTexCoord2f(x0, y1);
                Gl.glVertex2i(-realHO, realHeight - realVO);

                Gl.glTexCoord2f(x1, y1);
                Gl.glVertex2i(realWidth - realHO, realHeight - realVO);

                Gl.glTexCoord2f(x1, y0);
                Gl.glVertex2i(realWidth - realHO, -realVO);

                Gl.glTexCoord2f(x0, y0);
                Gl.glVertex2i(-realHO, -realVO);


                Gl.glEnd();

                Gl.glPopMatrix();

                if (preview != null)
                    preview = null;
            }
            else
            {
                playing = false;
            }



            Gl.glColor3i(1, 0, 1);
            Gl.glBindTexture(Gl.GL_TEXTURE_2D, 0);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2i(-animViewport.Width / 2, vLineScroll.Value);
            Gl.glVertex2i(animViewport.Width / 2, vLineScroll.Value);
            Gl.glVertex2i(hLineScroll.Value, -animViewport.Height / 2);
            Gl.glVertex2i(hLineScroll.Value, animViewport.Height / 2);
            Gl.glEnd();

            Gl.glColor3i(1, 0, 0);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex2i(-animViewport.Width / 2, -animViewport.Height/2);
            Gl.glVertex2i(-animViewport.Width / 2, animViewport.Height/2);

            Gl.glVertex2i(animViewport.Width / 2 -1, -animViewport.Height / 2);
            Gl.glVertex2i(animViewport.Width / 2 -1, animViewport.Height / 2);

            Gl.glVertex2i(-animViewport.Width / 2, animViewport.Height/2);
            Gl.glVertex2i(animViewport.Width / 2, animViewport.Height / 2);

            Gl.glVertex2i(-animViewport.Width / 2, -animViewport.Height / 2);
            Gl.glVertex2i(animViewport.Width / 2, -animViewport.Height / 2);

            Gl.glColor4f(1, 1, 1, 1);

            Gl.glEnd();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.OK)
            {
                MakeTextureActive(LoadTexture(openFileDialog1.FileName));
               
            }
           
        }

        private void vSheetScroll_Scroll(object sender, ScrollEventArgs e)
        {
            lDebug.Text = vSheetScroll.Value.ToString();
            currentTexture.VOffset = vSheetScroll.Value;
            sheetGLControl.Refresh();
        }

        private void hSheetScroll_Scroll(object sender, ScrollEventArgs e)
        {
            lDebug.Text = hSheetScroll.Value.ToString();
            currentTexture.HOffset = hSheetScroll.Value;
            sheetGLControl.Refresh();

        }

        private void tZoom_Scroll(object sender, EventArgs e)
        {
            currentTexture.Zoom = tZoom.Value;

            UpdateScrollers();

            sheetGLControl.Refresh();
        }

        private void bDebug_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(sheetViewport.Width.ToString() +  " " + sheetViewport.Height.ToString());
            //sheetGLControl.Refresh();

            MessageBox.Show(currentSprite.GetCurrentSequence().FrameCount.ToString());
            currentSprite.GetCurrentSequence().ShowAll();
        }

        private void cTextures_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Texture i in textures)
            {
                if (cTextures.Text.Equals(i.Filename.ToString()))
                {
                    MakeTextureActive(i);
                   // MessageBox.Show("Making this active: " + i.Filename);
                    return;
                }

            }
        }

        private void sheetGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            //currentMouse = sheetGLControl.PointToClient(Control.MousePosition);
            currentMouse = e.Location;
            //currentMouse.X++;
            //currentMouse.Y++;
            currentMouse.X /= currentTexture.Zoom;
            currentMouse.Y /= currentTexture.Zoom;
            if (currentMouse.X > sheetViewport.Width)
                currentMouse.X = sheetViewport.Width;
            if (currentMouse.Y > sheetViewport.Height)
                currentMouse.Y = sheetViewport.Height;


            currentMouse.X += (int)currentTexture.HOffset;
            currentMouse.Y += (int)currentTexture.VOffset;

            if (currentMouse.X >= currentTexture.Width)
                currentMouse.X = currentTexture.Width - 1;
            if (currentMouse.Y >= currentTexture.Height)
                currentMouse.Y = currentTexture.Height -1;

            if (currentMouse.X < 0)
                currentMouse.X = 0;
            if (currentMouse.Y < 0)
                currentMouse.Y = 0;

            lDebug.Text = currentMouse.X.ToString() + ", " + currentMouse.Y.ToString();

            if (mouseDown == true)
            {
                currentTexture.FinishMouse = currentMouse;
                lDebug2.Text = (currentTexture.StartMouse.ToString() + " " + currentTexture.FinishMouse.ToString());
                sheetGLControl.Refresh();
                //if (startMouse.X > finishMouse.X)
                //{
                //    Point temp = startMouse;
                //    startMouse = finishMouse;
                //    finishMouse = temp;
                //}
            }
            else
                lDebug2.Text = "";


        }

        private void sheetGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            currentTexture.StartMouse = currentMouse;
            //MessageBox.Show("Mouse is down");
            mouseDown = true;

            //MessageBox.Show(mouseDown.ToString());

        }

        private void sheetGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown == false)
                return;
            mouseDown = false;

            Point start = currentTexture.StartMouse;
            Point finish = currentTexture.FinishMouse;

            if (cFrameLockX.Checked == false) tFrameXSource.Text = (start.X < finish.X ? start.X : finish.X).ToString();
            if (cFrameLockY.Checked == false) tFrameYSource.Text = (start.Y < finish.Y ? start.Y : finish.Y).ToString();
            if (cFrameLockWidth.Checked == false) tFrameWidth.Text = (Math.Abs(start.X - finish.X)+1).ToString();
            if (cFrameLockHeight.Checked == false)  tFrameHeight.Text = (Math.Abs(start.Y - finish.Y)+1).ToString();

            if (cFrameAnchorMid.Checked == true)
            {
                tFrameXAnchor.Text = (int.Parse((tFrameWidth.Text)) / 2.0).ToString();
                tFrameYAnchor.Text = (int.Parse((tFrameHeight.Text)) / 2.0).ToString();
            }
            
        }

        private void chkAlpha_CheckedChanged(object sender, EventArgs e)
        {
            if (alphaBlendingToolStripMenuItem.Checked == true)
            {
                Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_ONE_MINUS_SRC_ALPHA);
                Gl.glEnable(Gl.GL_BLEND);
            }
            else
            {
                //Gl.glBlendFunc(Gl.GL_SRC_ALPHA, Gl.GL_SRC_ALPHA);
                Gl.glDisable(Gl.GL_BLEND);
            }
            sheetGLControl.Refresh();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void numberFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void alphaBlendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alphaBlendingToolStripMenuItem.Checked = !alphaBlendingToolStripMenuItem.Checked;
        }

        private void cFrameAnchorMid_CheckedChanged(object sender, EventArgs e)
        {
            if (cFrameAnchorMid.Checked == true)
            {
                tFrameXAnchor.Text = (int.Parse(tFrameWidth.Text) / 2.0).ToString();
                tFrameYAnchor.Text = (int.Parse(tFrameHeight.Text) / 2.0).ToString();
            }
        }

        private void UpdateAnimSeqCombo()
        {
            cAnimSequence.Items.Clear();

            if (currentSprite == null || currentSprite.Sequences.Count == 0)
            {
                cAnimSequence.Text = "";
                return;
            }

            foreach (AnimSequence seq in currentSprite.Sequences)
            {
                cAnimSequence.Items.Add(seq.Name);
            }
            if (currentSprite.CurrentSequence != null)
                cAnimSequence.SelectedIndex = currentSprite.Sequences.IndexOf(currentSprite.CurrentSequence);
            playing = false;
            //cAnimSequence.Text = cAnimSequence.Items[cAnimSequence.Items.Count - 1].ToString();
        }

        private void bCreateFrame_Click(object sender, EventArgs e)
        {
            if (currentSprite == null)
            {
                MessageBox.Show("You must create a sprite to work with first.");
                return;
            }
            if (currentSprite.CurrentSequence == null)
            {
                MessageBox.Show("You must create an animation sequence first.");
                return;
            }

            Frame temp = new Frame(double.Parse(tFrameTime.Text), double.Parse(tFrameRotation.Text), cHFlip.Checked, cVFlip.Checked,
            double.Parse(tFrameXScale.Text), double.Parse(tFrameYScale.Text), int.Parse(tFrameXSource.Text), int.Parse(tFrameYSource.Text), int.Parse(tFrameWidth.Text),
            int.Parse(tFrameHeight.Text), double.Parse(tFrameXAnchor.Text), double.Parse(tFrameYAnchor.Text), currentTexture);

            currentSprite.CurrentSequence.AddFrame(temp);
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            cFrameEditMode.Checked = false;
            if (currentSprite == null || currentSprite.CurrentSequence == null)
                return;

            if (playing)
            {
                playing = false;
                bPlay.Text = "Play";
            }
            else
            {
                if (playingFrame > currentSprite.CurrentSequence.FrameCount)
                    playingFrame = 0;
                playing = true;
                bPlay.Text = "Pause";
            }
            start = DateTime.Now.Ticks;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (playing)
                sheetGLControl.Draw();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = exportDialog.ShowDialog();

            if (r == DialogResult.OK)
            {
                if (File.Exists(exportDialog.FileName))
                    File.Delete(exportDialog.FileName); //nuke it because updating is not implemented
                //currentSprite.Export(exportDialog.FileName);
                foreach (Sprite s in sprites)
                {
                    s.Export(exportDialog.FileName);
                }
            }
        }

        private void UpdateMouse()
        {
            if (currentTexture == null) return;

            if (tFrameXSource.Text == "") return;
            if (tFrameYSource.Text == "") return;
            if (tFrameWidth.Text == "") return;
            if (tFrameHeight.Text == "") return;

            int x, y, w, h;

            x = int.Parse(tFrameXSource.Text);
            if (x > currentTexture.Width - 1 || x < 0) return;

            y = int.Parse(tFrameYSource.Text);
            if (y > currentTexture.Height - 1|| y < 0) return;

            w = int.Parse(tFrameWidth.Text);
            if (x + w > currentTexture.Width || w < 0) return;
            
            h = int.Parse(tFrameHeight.Text);
            if (y + h > currentTexture.Height || h < 0) return;

            Point start = new Point(x,y);
            Point finish = new Point(x + w, y + h);

            currentTexture.StartMouse = start;
            currentTexture.FinishMouse = finish;

            sheetGLControl.Draw();
        }

        private void tFrame_TextChanged(object sender, EventArgs e)
        {
            UpdateMouse();
        }

        private void bFrameAddFromFile_Click(object sender, EventArgs e)
        {
            if (currentSprite == null) return;
            if (currentSprite.CurrentSequence == null) return;

            DialogResult r = fileAddFrames.ShowDialog();
            if (r != DialogResult.OK)
                return;


            foreach (string file in fileAddFrames.FileNames)
            {
                bool loaded = false;
                foreach (Texture tex in textures)
                {
                    if (tex.Filename == file)
                    {
                        loaded = true;
                        currentTexture = tex;
                        break;
                    }
                }
                if (loaded == false)
                {
                    currentTexture = LoadTexture(file);
                    textures.Add(currentTexture);
                }

                double xanc, yanc;
                int xsource, ysource, width, height;
                if (cFrameLockX.Checked == true) xsource = int.Parse(tFrameXSource.Text); else xsource = 0;
                if (cFrameLockY.Checked == true) ysource = int.Parse(tFrameYSource.Text); else ysource = 0;
                if (cFrameLockWidth.Checked == true) width = int.Parse(tFrameWidth.Text); else width = currentTexture.Width;
                if (cFrameLockHeight.Checked == true) height = int.Parse(tFrameHeight.Text); else height = currentTexture.Height;

                if (cFrameAnchorMid.Checked == true)
                {
                    xanc = currentTexture.Width / 2;
                    yanc = currentTexture.Height / 2;
                }
                else
                {
                    xanc = double.Parse(tFrameXAnchor.Text);
                    yanc = double.Parse(tFrameYAnchor.Text);
                }

                Frame frame = new Frame(double.Parse(tFrameTime.Text), 0, false, false, double.Parse(tFrameXScale.Text), double.Parse(tFrameYScale.Text),
                    xsource, ysource , width, height, xanc, yanc, currentTexture);
                currentSprite.CurrentSequence.AddFrame(frame);
            }
        }

        private void bEditAnimSeq_Click(object sender, EventArgs e)
        {
            if (currentSprite == null || currentSprite.CurrentSequence == null) return;
            EditSequence editForm = new EditSequence(currentSprite.CurrentSequence);
            editForm.ShowDialog();
            UpdateAnimSeqCombo();
        }

        private void cDeleteAnimSeq_Click(object sender, EventArgs e)
        {
            if (currentSprite == null || currentSprite.CurrentSequence == null) return;
            DialogResult r = MessageBox.Show("Are you sure you want to delete the sequence?", "Confirm deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                currentSprite.DeleteCurrentSequence();
                playing = false;
                UpdateAnimSeqCombo();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateSprite();
        }

        private bool CreateSprite()
        {
            CreateSprite cs = new CreateSprite();
            DialogResult r = cs.ShowDialog();

            if (r == DialogResult.OK)
            {
                playing = false;
                currentSprite = new Sprite(cs.SpriteName);
                UpdateAnimSeqCombo();
                sprites.Add(currentSprite);
                exportToolStripMenuItem.Enabled = true;


                ToolStripMenuItem spritemenu = new ToolStripMenuItem(currentSprite.Name);

                spritemenu.Click += new System.EventHandler(MakeSpriteActive);

                spritesToolStripMenuItem.DropDownItems.Add(spritemenu);
                //this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);

                return true;
            }
            else
            {
                return false;
            }

            
        }

        public void MakeSpriteActive(object sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Text;
            foreach (Sprite s in sprites)
            {
                if (name == s.Name)
                {
                    if (s == currentSprite)
                        return;
                    MakeSpriteActive(s);
                    return;
                }

            }
            MessageBox.Show("There seems to be an error.  The sprite couldn't be found.");
        }

        private void MakeSpriteActive(Sprite sprite)
        {
            currentSprite = sprite;
            UpdateAnimSeqCombo();
            //MessageBox.Show("Switched to " + currentSprite.Name);
            //Animation sequences
            //etc
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult r = importDialog.ShowDialog();

            if (r != DialogResult.OK)
                return;

            XmlDocument doc = new XmlDocument();
            doc.Load(importDialog.FileName);
            XmlNode root = doc.DocumentElement;
            XmlElement spriteElement = (XmlElement)root.FirstChild;

            do
            {
                bool add = true;
                bool cancel = false;
                Sprite temp = new Sprite("blank");
                string sName = spriteElement.GetAttribute("Name");
                foreach (Sprite s in sprites)
                {
                    if (s.Name == sName)
                    {
                        if (MessageBox.Show("Are you sure you want to overwrite " + sName + "?", "Warning", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                        {
                            sprites[sprites.IndexOf(s)] = temp;
                            add = false;
                            break;
                        }
                        else cancel = true;
                    }
                }
                if (cancel)
                    continue;


                try
                {
                    bool success = false;
                    success = temp.Import(importDialog.FileName, textures, sheetViewport.Width, sheetViewport.Height, doc, spriteElement);
                    if (success)
                    {
                        currentSprite = temp;
                        if (add)
                        {
                            sprites.Add(currentSprite);
                            ToolStripMenuItem spritemenu = new ToolStripMenuItem(currentSprite.Name);
                            spritemenu.Click += new System.EventHandler(MakeSpriteActive);
                            spritesToolStripMenuItem.DropDownItems.Add(spritemenu);
                            exportToolStripMenuItem.Enabled = true;
                        }
                    }
                }
                catch (Exception filenotfound)
                {
                    MessageBox.Show(filenotfound.ToString());
                }



                UpdateAnimSeqCombo();

                cTextures.Items.Clear();
                foreach (Texture tex in textures)
                    cTextures.Items.Add(tex.Filename);
                cTextures.Text = cTextures.Items[cTextures.Items.Count - 1].ToString();
            } while ((spriteElement = (XmlElement)spriteElement.NextSibling) != null);
        }

        private void bNewAnimSeq_Click(object sender, EventArgs e)
        {
            if (currentSprite == null)
                if (CreateSprite() == false)
                {
                    MessageBox.Show("You must be working in a sprite first.");
                    return;
                }

            Form2 temp = new Form2();
            //temp.ShowDialog();
            //if (temp.res
            DialogResult r = temp.ShowDialog();
            if (r != DialogResult.OK) return;

            currentSprite.AddSequence(new AnimSequence(temp.SequenceName));
            UpdateAnimSeqCombo();

        }

        private void cAnimSequence_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSprite.SetActiveSequence(cAnimSequence.SelectedIndex);
            //playing = false;
            playingFrame = 0;
            sheetGLControl.Draw();
            //MessageBox.Show(currentSprite.GetCurrentSequence().Name);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (currentSprite == null || currentSprite.CurrentSequence == null)
                return;
            DialogResult r = MessageBox.Show("Are you sure you want to exit?  All unsaved work will be lost.", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
            if (r != DialogResult.Yes)
                e.Cancel = true;
        }

        private void vLineScroll_Scroll(object sender, ScrollEventArgs e)
        {
            sheetGLControl.Draw();
        }

        private void hLineScroll_Scroll(object sender, ScrollEventArgs e)
        {
            sheetGLControl.Draw();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            //sheetGLControl.Width = this.Width;
            //sheetGLControl.Height = this.Height;
            //sheetViewport = new Rectangle(0,                                        sheetGLControl.Height - (int)(415.0 / 740.0 * sheetGLControl.Height), (int)(613.0 / 1024.0 * sheetGLControl.Width), (int)(415.0 / 740.0 * sheetGLControl.Height));
            //animViewport = new Rectangle((int)(660.0 / 1024.0 * sheetGLControl.Width), sheetGLControl.Height - (int)(280.0 / 740.0 * sheetGLControl.Height) -30, (int)(300.0 / 1024.0 * sheetGLControl.Width), (int)(280.0 / 740.0 * sheetGLControl.Height));
            //foreach (Control c in this.Controls)
            //{
            //    if (c == sheetGLControl) continue;
            //    double x = c.Location.X; double y = c.Location.Y;
            //    //MessageBox.Show("Old point is " + new Point((int)x, (int)y).ToString());
            //    x = (int)(x * this.Width / 1024.0);
            //    y = (int)(y * this.Height / 740);
            //    c.Location = new Point((int)x, (int)y);
            //    //MessageBox.Show("New point is " + new Point((int)x, (int)y).ToString());
            //    //c.Location.Y = y;
            //    //MessageBox.Show("Old = " + c.Width.ToString());
            //    //c.Width = (int)(c.Width * this.Width / 1024.0);
            //    //MessageBox.Show("New = " + c.Width.ToString());
            //    //c.Height = (int)(c.Height * this.Height / 740);
            //}
            
        }

        private void cFrameMulti_CheckedChanged(object sender, EventArgs e)
        {
            lFrameXSpacing.Enabled = cFrameMulti.Checked;
            lFrameNumber.Enabled = cFrameMulti.Checked;
            tFrameXSpacing.Enabled = cFrameMulti.Checked;
            tFrameNumber.Enabled = cFrameMulti.Checked;
        }

        private void cFrameEditMode_CheckedChanged(object sender, EventArgs e)
        {
            bool value = cFrameEditMode.Checked;
            if (value)
            {
                playing = false;
                //bPlay.Enabled = false;
                bPreviewFrame.Enabled = true;
                bFrameDelete.Enabled = true;
                bApplyFrame.Enabled = true;
                bCreateFrame.Enabled = false;
                bFrameAddFromFile.Enabled = false;
                if (currentSprite != null && currentSprite.CurrentSequence != null)
                    DumpFrameToBoxes();
            }
            else
            {
                //bPlay.Enabled = true;
                bPreviewFrame.Enabled = false;
                bFrameDelete.Enabled = false;
                bApplyFrame.Enabled = false;
                bCreateFrame.Enabled = true;
                bFrameAddFromFile.Enabled = true;
            }
        }

        private void bFrameNext_Click(object sender, EventArgs e)
        {
            playing = false;
            if (currentSprite == null || currentSprite.CurrentSequence == null) return;
            playingFrame++;
            if (playingFrame >= currentSprite.CurrentSequence.FrameCount)
                playingFrame = currentSprite.CurrentSequence.ReturnLoopFrame;
            sheetGLControl.Draw();
            DumpFrameToBoxes();
        }

        private void bFramePrevious_Click(object sender, EventArgs e)
        {
            PreviousFrame();
        }

        private void PreviousFrame()
        {
            playing = false;
            if (currentSprite == null || currentSprite.CurrentSequence == null) return;
            playingFrame--;
            if (playingFrame < 0)
                playingFrame = currentSprite.CurrentSequence.FrameCount - 1;
            sheetGLControl.Draw();
            DumpFrameToBoxes();
        }

        private void DumpFrameToBoxes()
        {
            Frame currentFrame = currentSprite.CurrentSequence.Frames[playingFrame];
            tFrameXSource.Text = currentFrame.XSource.ToString();
            tFrameYSource.Text = currentFrame.YSource.ToString();
            tFrameWidth.Text = currentFrame.Width.ToString();
            tFrameHeight.Text = currentFrame.Height.ToString();
            tFrameXScale.Text = currentFrame.XScale.ToString();
            tFrameYScale.Text = currentFrame.YScale.ToString();
            tFrameTime.Text = currentFrame.Time.ToString();
            tFrameXAnchor.Text = currentFrame.XAnchor.ToString();
            tFrameYAnchor.Text = currentFrame.YAnchor.ToString();
            tFrameRotation.Text = currentFrame.Rotation.ToString();
            cHFlip.Checked = currentFrame.HFlip;
            cVFlip.Checked = currentFrame.VFlip;
            cTextures.Text = currentFrame.Texture.Filename;
        }

        private void BoxesToFrame(Frame frame)
        {
            frame.XSource = int.Parse(tFrameXSource.Text);
            frame.YSource = int.Parse(tFrameYSource.Text);
            frame.Width = int.Parse(tFrameWidth.Text);
            frame.Height = int.Parse(tFrameHeight.Text);
            frame.XScale = double.Parse(tFrameXScale.Text);
            frame.YScale = double.Parse(tFrameYScale.Text);
            frame.Time = double.Parse(tFrameTime.Text);
            frame.XAnchor = double.Parse(tFrameXAnchor.Text);
            frame.YAnchor = double.Parse(tFrameYAnchor.Text);
            frame.Rotation = double.Parse(tFrameRotation.Text);
            frame.HFlip = cHFlip.Checked;
            frame.VFlip = cVFlip.Checked;
        }

        private void bPreviewFrame_Click(object sender, EventArgs e)
        {
            preview = new Frame(currentSprite.CurrentSequence.Frames[playingFrame]);
            BoxesToFrame(preview);
            sheetGLControl.Draw();
        }

        private void bApplyFrame_Click(object sender, EventArgs e)
        {
            Frame f = currentSprite.CurrentSequence.Frames[playingFrame];
            BoxesToFrame(f);
        }

        private void bFrameDelete_Click(object sender, EventArgs e)
        {
            if (currentSprite == null || currentSprite.CurrentSequence == null || currentSprite.CurrentSequence.FrameCount == 0) return;

            currentSprite.CurrentSequence.DeleteFrame(playingFrame);
            PreviousFrame();
        }

        private void tFrameNumber_TextChanged(object sender, EventArgs e)
        {
            sheetGLControl.Draw();
        }

        private void tFrameXSpacing_TextChanged(object sender, EventArgs e)
        {
            sheetGLControl.Draw();
        }




    }
}
