using System.Drawing;

namespace SharedInterfaces
{
    public interface IAncientScript
    {
        string GetOrigin();
        string Translate(string rawData);
        Image GetEmblem();
    }
}