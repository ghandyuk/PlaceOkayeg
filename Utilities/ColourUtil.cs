using Microsoft.AspNetCore.Components;
using SixLabors.ImageSharp.PixelFormats;

namespace Place.Utilities;

public static class ColourUtil
{
    // based on https://stackoverflow.com/a/1855903
    public static Rgba32 CalculateConstrastColour(Rgba32 colour)
    {
        double luminance = (0.299 * colour.R + 0.587 + colour.G + 0.114 * colour.B) / 255;
        float d = luminance > 0.5 ? 0 : 255;
        return new Rgba32(d, d, d);
    }
}