# Lat / Lng to Swiss Grid conversion in C#
🇨🇭 C# Functionality for converting **Latitude and Longitude** *(WGS84)* values to **The Swiss coordinate system** *(or Swiss grid)*. \*

\* also sometimes referred to as *CH1903 or LV09*.

📱 This C# code has been derived from that used in my [Grid Ref CH1903](https://www.mike-irving.co.uk/portfolio/mobile-apps/grid-ref-ch1903/) mobile app.

## How to use

⬇️ Download the repository and open the *LatLngToSwissGrid.sln* file in [Visual Studio](https://visualstudio.microsoft.com/).

▶️ Then run it.

✏️ Modify *Program.cs* to set the WGS84 Latitude and Longitude input variables - *lat* and *lng*.

### Example

`Functions.LLtoSwissGrid(46.963112, 7.464872, out swissEasting, out swissNorthing);`

would return `swissEasting = 601997`, `swissNorthing = 201337`

### Files of interest

Whilst the entire repository can be compiled and used as a C# / .NET Console App, these are the main files.

💻 **Program.cs** - the controller of the console app, showing you how to use the *LLtoSwissGrid (double Lat, double Long, out double SwissEasting, out double SwissNorthing)* function.

🔢 **Functions.cs** - the mathematical functions that perform the grid coordinate conversion.

### Contributions

🍴 Feel free to Fork / Branch / Modify, raise any Pull Requests for changes.

#### Also available

Lat / Lng to: [Gauss–Krüger](https://github.com/mikeirvingweb/LatLngToGaussKruger).
