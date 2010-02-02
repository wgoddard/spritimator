using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Tao.OpenGl;
using Tao.DevIl;
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

        public Texture(string file_name, int framewidth, int frameheight)
        {
            filename = file_name;
           // Il.ilDeleteImage(images[0]);

            textureID = Ilut.ilutGLLoadImage(filename);
            Gl.glTexParameteri(Gl.GL_TEXTURE_2D, Gl.GL_TEXTURE_MAG_FILTER, Gl.GL_NEAREST);

            //Gl.glBindTexture(Gl.GL_TEXTURE_2D, textureID);

            width = Il.ilGetInteger(Il.IL_IMAGE_WIDTH);
            height = Il.ilGetInteger(Il.IL_IMAGE_HEIGHT);

            hdiff = width - framewidth;
            vdiff = height - frameheight;

        }

        ~Texture()
        {
            //Ilu.iluDeleteImage(textureID);
            Il.ilDeleteImage(textureID);
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
