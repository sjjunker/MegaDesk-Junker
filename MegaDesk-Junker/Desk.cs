using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Junker
{
    public class Desk
    {
        private int width;
        private int depth;
        private int numDrawers;
        private SurfaceMaterial surfaceMaterial;

        public static int MIN_WIDTH = 24;
        public static int MAX_WIDTH = 96;
        public static int MIN_DEPTH = 12;
        public static int MAX_DEPTH = 48;
        public static int MIN_DRAWERS = 0;
        public static int MAX_DRAWERS = 7;

        public Desk(int width, int depth, int numDrawers, SurfaceMaterial surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Depth
        {
            get { return depth; }
            set { depth = value; }
        }

        public int NumDrawers
        {
            get { return numDrawers; }
            set { numDrawers = value; }
        }

        public SurfaceMaterial SurfaceMaterial
        {
            get { return surfaceMaterial; }
            set { surfaceMaterial = value; }
        }

        public int SurfaceArea()
        {
            return width * depth;
        }
    }

    public enum SurfaceMaterial
    {
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125,
        Pine = 50
    }
}
