namespace LoggingKata
{
    public class TacoBell:ITrackable
    {
        public string Name;
        public Point Location;

        Point ITrackable.Location 
        {
            get =>  Location;
            set => Location = value; 
        }

        public TacoBell(string name, Point p)
        {
            Name = name;
            Location = p;
        }
        public TacoBell()
        {

        }
        public string GetName()
        {
            return Name;
        }

        public void SetName(string value)
        {
            Name = value;
        }

        //public Point getLocation()
        //{
         //   return Location;
       // }
       // public void setLocation(Point b)
       // {
       //     Location = b;
       // }
    }
}