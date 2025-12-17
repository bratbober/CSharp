// FileStream 
// StreamReader, StreamWriter
// BinaryReader, BinaryWriter
// Серіалізація об'єктів(XML, JSON)

using _013_Files;
using System.IO;
using System.Text;
using System.Xml.Serialization;

/*string path = "example.txt";
using FileStream fileStream = new FileStream(path,
    FileMode.OpenOrCreate,
    FileAccess.Write
    ); 

string text = "Hello, World!";
byte[] bytes = Encoding.UTF8.GetBytes(text);

fileStream.Write(bytes, 0, bytes.Length);*/

/*string path = "example.txt";
using FileStream fileStream = new FileStream(path,
    FileMode.Open,
    FileAccess.Read
    );
byte[] bytes = new byte[fileStream.Length];
fileStream.Read(bytes, 0, bytes.Length);
string text = Encoding.UTF8.GetString(bytes);
Console.WriteLine(text);*/

/*string path = "data.txt";
using StreamWriter writer = new StreamWriter(path);
int a = 4, b = 5;
writer.WriteLine("Hello");
writer.WriteLine(200);
writer.WriteLine("aaaa");
writer.WriteLine($"a = {a}, b = {b}");*/

/*string path = "data.txt";
using StreamReader streamReader = new StreamReader(path);
string text = streamReader.ReadToEnd();
Console.WriteLine(text);

string line = null;
while((line = streamReader.ReadLine()) != null)
{
    Console.WriteLine(line);
}*/

/*Point point = new Point() {X = 4, Y = 5 };

string path = "point.txt";

using StreamWriter writer = new StreamWriter(path);
writer.WriteLine(point);*/


/*string path = "point.txt";
using StreamReader stream = new StreamReader(path);
string line = stream.ReadLine();

Console.WriteLine(line);
string[] parts = line.Split(",");
Console.WriteLine(parts[0]);
Console.WriteLine(parts[1]);

Point point = new Point();
point.X = Convert.ToInt32(parts[0]);
point.Y = Convert.ToInt32(parts[1]);

Console.WriteLine(point);*/

/*string path = "point.txt";
using StreamReader streamReader = new StreamReader(path);
List<Point> points = new List<Point>();
string line = null;
while((line = streamReader.ReadLine()) != null)
{
    Point point = new Point();
    string[] parts = line.Split(",");

    point.X = Convert.ToInt32(parts[0]);
    point.Y = Convert.ToInt32(parts[1]);
    points.Add(point);

}
    
foreach(Point point in points)
    Console.WriteLine(point);*/


/*string path = "data.bin";
using FileStream fileStream = new FileStream(path,
    FileMode.OpenOrCreate,
    FileAccess.Write
    );
using BinaryWriter binaryWriter = new BinaryWriter(fileStream);
binaryWriter.Write(10.2);
binaryWriter.Write("Hello World");
binaryWriter.Write(true);*/

/*string path = "data.bin";
using FileStream fileStream = new FileStream(path,
    FileMode.Open,
    FileAccess.Read
    );
using BinaryReader binaryReader = new BinaryReader( fileStream );
double d = binaryReader.ReadDouble();
string s = binaryReader.ReadString();
bool b = binaryReader.ReadBoolean();

Console.WriteLine(d);
Console.WriteLine(s);
Console.WriteLine(b);*/


// Серіалізація(Serialization) - це збереження стану
// об'єкта з метою його подальшого відтворення

// Serialization
/*Point point = new Point { X = 10, Y = 20 };
XmlSerializer xmlSerializer = new XmlSerializer(typeof(Point));
string path = "point.xml";
using FileStream fileStream = new FileStream(path,FileMode.Create);
xmlSerializer.Serialize(fileStream, point);*/

// Deserialization 
/*string path = "point.xml";
using FileStream fileStream = new FileStream(path, FileMode.Open);
XmlSerializer xmlSerializer = new XmlSerializer(typeof(Point));
Point point = (Point)xmlSerializer.Deserialize(fileStream);
Console.WriteLine(point);*/



List<Point> points = new List<Point>
{
    new Point{ X = 10, Y = 10 },
    new Point{ X = 20, Y = 20 },
    new Point{ X = 30, Y = 30 },
};
XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Point>),
    new XmlRootAttribute()
    {
        ElementName = "Points"
    }
    );
string path = "listPoint.xml";
using FileStream file = new FileStream(path, FileMode.Create);
xmlSerializer.Serialize(file, points);

/*string path = "listPoint.xml";
using FileStream file = new FileStream(path, FileMode.Open);
XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Point>));
List<Point> points = (List<Point>)xmlSerializer.Deserialize(file);
foreach(Point point in points)
    Console.WriteLine(point);*/