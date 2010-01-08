using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spritimator_Tao
{
    class Frame
    {
        //string name;
        double time;
        double rotation;
        bool hFlip;
        bool vFlip;
        double xScale;
        double yScale;
        int xSource;
        int ySource;
        int width;
        int height;
        double xAnchor;
        double yAnchor;
        //
        Texture texture;
        int textudeID;

        public Frame(double _time, double _rotation, bool _hflip, bool _vflip,
            double _xscale, double _yscale, int _xsource, int _ysource, int _width,
            int _height, double _xanchor, double _yanchor, Texture _texture)
        {
           // name = _name;
            time = _time;
            rotation = _rotation;
            hFlip = _hflip;
            vFlip = _vflip;
            xScale = _xscale;
            yScale = _yscale;
            xSource = _xsource;
            ySource = _ysource;
            width = _width;
            height = _height;
            xAnchor = _xanchor;
            yAnchor = _yanchor;
            texture = _texture;
        }

        public Frame(Frame frame)
        {
           // name = frame.name;
            time = frame.time;
            rotation = frame.rotation;
            hFlip = frame.hFlip;
            vFlip = frame.vFlip;
            xScale = frame.xScale;
            yScale = frame.yScale;
            xSource = frame.xSource;
            ySource = frame.ySource;
            width = frame.width;
            height = frame.height;
            xAnchor = frame.xAnchor;
            yAnchor = frame.yAnchor;
            texture = frame.texture;
        }

        public void Show()
        {
            MessageBox.Show(
                "Time: " + time.ToString() + '\n' +
                "Rotation: " + rotation.ToString() + '\n' +
                "hFlip: " + hFlip.ToString() + '\n' +
                "vFlip: " + vFlip.ToString() + '\n' +
                "xSource: " + xSource.ToString() + '\n'
                );
        }


        public double Time { get { return time; } set { time = value; } }
        public double Rotation { get { return rotation; } set { rotation = value; } }
        public bool HFlip { get { return hFlip; } set { hFlip = value; } }
        public bool VFlip { get { return vFlip; } set { vFlip = value; } }
        public double XScale { get { return xScale; } set { xScale = value; } }
        public double YScale { get { return yScale; } set { yScale = value; } }
        public int XSource { get { return xSource; } set { xSource = value; } }
        public int YSource { get { return ySource; } set { ySource = value; } }
        public int Width { get { return width; } set {width = value; } }
        public int Height { get { return height; } set { height = value; } }
        public double XAnchor { get { return xAnchor; } set { xAnchor = value; } }
        public double YAnchor { get { return yAnchor; } set { yAnchor = value; } }
        public Texture Texture { get { return texture; } set { texture = value; } }


    }
}
