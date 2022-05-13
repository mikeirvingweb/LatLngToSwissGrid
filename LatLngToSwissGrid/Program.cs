using LatLngToSwissGrid;

// Input Variables: WGS84 Latitude and Longitude
double lat = 46.963112;
double lng = 7.464872;

// Output Variables: CH1903 / LV09 Easting and Northing
double swissEasting;
double swissNorthing;

Functions.LLtoSwissGrid(lat, lng, out swissEasting, out swissNorthing);

Console.WriteLine("Lat: " + lat.ToString() + ", Lng: " + lng.ToString() + " = Swiss Grid: " + Convert.ToInt32(Math.Floor(swissEasting)).ToString() + " / " + Convert.ToInt32(Math.Floor(swissNorthing)).ToString() + Environment.NewLine);
Console.WriteLine("Swiss Coordinate System Grid (CH1903 / LV09)");