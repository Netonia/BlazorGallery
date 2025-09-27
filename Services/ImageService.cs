using System.Net.Http.Json;

namespace BlazorGallery.Services;

public enum SortOrder
{
    Name,
    DateNewest,
    DateOldest
}

public class ImageInfo
{
    public string Filename { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<string> Tags { get; set; } = new();
    public DateTime DateCreated { get; set; }
    public string Url => $"images/{Filename}";
    public string ThumbnailUrl => $"images/{Filename}"; // Same as URL for now, could be optimized later
}

public class ImageService
{
    private readonly HttpClient _httpClient;
    private List<ImageInfo>? _images;

    public ImageService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ImageInfo>> GetImagesAsync()
    {
        if (_images != null)
            return _images;

        try
        {
            // Try to load from images.json
            _images = await _httpClient.GetFromJsonAsync<List<ImageInfo>>("images.json");
            return _images ?? new List<ImageInfo>();
        }
        catch
        {
            // Fallback: return empty list or hardcoded images
            _images = new List<ImageInfo>
            {
                new ImageInfo 
                { 
                    Filename = "sample1.jpg", 
                    Title = "Sample Image 1", 
                    Description = "A sample image",
                    Tags = new List<string> { "sample" },
                    DateCreated = DateTime.Now.AddDays(-3)
                },
                new ImageInfo 
                { 
                    Filename = "sample2.jpg", 
                    Title = "Sample Image 2", 
                    Description = "Another sample image",
                    Tags = new List<string> { "sample" },
                    DateCreated = DateTime.Now.AddDays(-2)
                },
                new ImageInfo 
                { 
                    Filename = "sample3.jpg", 
                    Title = "Sample Image 3", 
                    Description = "Yet another sample image",
                    Tags = new List<string> { "sample" },
                    DateCreated = DateTime.Now.AddDays(-1)
                }
            };
            return _images;
        }
    }

    public async Task<ImageInfo?> GetImageByFilenameAsync(string filename)
    {
        var images = await GetImagesAsync();
        return images.FirstOrDefault(i => i.Filename.Equals(filename, StringComparison.OrdinalIgnoreCase));
    }
}