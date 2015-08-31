using System;

using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using Tao.OpenGl;
using OpenTK.Graphics.OpenGL;
//using Tao.Platform.Windows;

namespace Spritimator_Tao
{


    class Texture
    {

        int height;
        int width;
        int textureID;
        int ho = 0;
        int vo = 0;
        int hdiff = 0;
        int vdiff = 0;
        int zoom = 1;
        string filename;
        Point startMouse = new Point();
        Point finishMouse = new Point(0, 0);

        int LoadTexture(string filename)
        {
            if (String.IsNullOrEmpty(filename))
                throw new ArgumentException(filename);

            int id = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, id);

            // We will not upload mipmaps, so disable mipmapping (otherwise the texture will not appear).
            // We can use GL.GenerateMipmaps() or GL.Ext.GenerateMipmaps() to create
            // mipmaps automatically. In that case, use TextureMinFilter.LinearMipmapLinear to enable them.
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            Bitmap bmp = new Bitmap(filename);
            BitmapData bmp_data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            width = bmp.Width;
            height = bmp.Height;

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bmp_data.Width, bmp_data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, bmp_data.Scan0);

            bmp.UnlockBits(bmp_data);

            return id;
        }

        public Texture(string file_name, int framewidth, int frameheight)
        {
            textureID = LoadTexture(file_name);
            filename = file_name;

           // Il.ilDeleteImage(images[0]);

            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);

            //Gl.glBindTexture(Gl.GL_TEXTURE_2D, textureID);


            hdiff = width - framewidth;
            vdiff = height - frameheight;

        }

        ~Texture()
        {
            //Ilu.iluDeleteImage(textureID);
           // Il.ilDeleteImage(textureID);
        }

        public Texture()
        {
            textureID = 0;
            width = 1;
            height = 1;
        }

        public int TextureID
        {
            get
            {
                return textureID;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }

        }

        public int Height
        {
            get
            {
                return height;
            }
        }

        public int HOffset
        {
            get
            {
                return ho;
            }
            set
            {
                ho = value;
            }
        }

        public int VOffset
        {
            get
            {
                return vo;
            }
            set
            {
                vo = value;
            }
        }

        public int HDiff
        {
            get
            {
                return hdiff;
            }
            set
            {
                hdiff = value;
            }
        }

        public int VDiff
        {
            get
            {
                return vdiff;
            }
            set
            {
                vdiff = value;
            }
        }

        public int Zoom
        {
            get
            {
                return zoom;
            }
            set
            {
                zoom = value;
            }
        }

        public string Filename
        {
            get
            {
                return filename;
            }
        }

        public Point StartMouse
        {
            get
            {
                return startMouse;
            }
            set
            {
                startMouse = value;
            }
        }

        public Point FinishMouse
        {
            get
            {
                return finishMouse;
            }
            set
            {
                finishMouse = value;
            }
        }




    }
}
