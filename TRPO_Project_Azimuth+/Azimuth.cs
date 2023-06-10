namespace TRPO_Project_Azimuth_
{
    public class Azimuth
    {
        public double Ugl { get;  }

        public int Tysychnay_USSR_RUS { get {
            return (int)(Ugl * 16.667) ; 
            }}

        public int Tysychnay_USSR_RUS_obr
        {
            get
            {
                return (int)(ObrDirUgl * 16.667);
            }
        }

        public int MRLD
        {
            get
            {
                return (int)(Ugl * 17.7777);
            }
        }

        public int MRLD_obr
        {
            get
            {
                return (int)(ObrDirUgl * 17.7777);
            }
        }

        public double SSM { get;  } // Среднее сближение мередиан.
        public double PN { get;  }  // Поправка направления.
        public double ObrDirUgl
        {
            get
            {
                if (Ugl > 180) return (Ugl - 180);
                else return (Ugl + 180);
            }
        }

        public double Geo_Azim
        {
            get
            {
                return Ugl + SSM;
            }
        }

        public double Mag_AziN
        {
            get
            {
                return Ugl + PN;
            }
        }
        public Azimuth(double ugol, double pn)
        {
            if(ugol > 360)
            {
                ugol = ugol % 360;
            }
            Ugl = ugol;
            PN = pn;
        }

        public Azimuth(double ugl, double ssm, double magSkl)
        {
            Ugl = ugl;
            PN = ssm + magSkl;
            
        }

        public Point PGZ(Point point, double dist)
        {
            ///
            ///dist = Math.Sqrt(Math.Pow(dist, 2) - Math.Pow(h - H, 2));

            double y = Math.Cos((Ugl + 270) * (Math.PI / 180.0)) * dist;

            double x = Math.Sin((Ugl + 270) * (Math.PI / 180.0)) * dist;


            return new Point(point.X + (int)x, point.Y + (int)y);
        }
    }
}