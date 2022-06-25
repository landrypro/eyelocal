using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeLocal.coremonitor
{
    class Position
    {
        //Property
        float longitude;
        float latitude;
        string mapURL;

        //Constructors
        public Position() { }
        public Position(float lg, float lat, string url)
        {
            this.longitude = lg;
            this.latitude = lat;
            this.mapURL = url;
        }

        //Getter
        public string getUrlMap() { return this.mapURL; }
        public float getlg() { return this.longitude; }
        public float getlat() { return this.latitude; }
        

        //Setter
        public void setUrlMap(string url) { this.mapURL = url; }
        public void setlongitude(float lg) { this.longitude = lg; }
        public void setlatitude(float lat) { this.latitude = lat; }

        

    }
}
