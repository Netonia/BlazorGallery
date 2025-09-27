# Blazor Photo Gallery

A simple, static photo gallery built with Blazor WebAssembly, designed for easy deployment to GitHub Pages.

## Features

- **Responsive Grid**: Images displayed in a responsive Bootstrap grid layout
- **Lightbox Viewer**: Click on any image to view it full-screen with navigation
- **Keyboard Navigation**: Use arrow keys to navigate between images in lightbox, Escape to close
- **Image Metadata**: Support for titles, descriptions, tags, and dates via JSON configuration
- **Lazy Loading**: Images are loaded lazily for better performance
- **Mobile Friendly**: Responsive design that works on mobile, tablet, and desktop

## Quick Start

1. **Add your images**: Place your image files in `wwwroot/images/`
2. **Configure metadata** (optional): Edit `wwwroot/images.json` to add titles, descriptions, and tags
3. **Deploy**: The project is configured for automatic GitHub Pages deployment

## Project Structure

```
├── Components/
│   ├── Gallery.razor      # Main image grid component
│   ├── Lightbox.razor     # Full-screen image viewer
│   └── Navbar.razor       # Navigation bar with search/sort
├── Services/
│   └── ImageService.cs    # Image loading and management
├── wwwroot/
│   ├── images/           # Place your image files here
│   └── images.json       # Image metadata configuration
└── .github/workflows/
    └── deploy.yml        # GitHub Pages deployment
```

## Configuration

### Adding Images

Simply place your image files (JPG, PNG, etc.) in the `wwwroot/images/` directory.

### Image Metadata

Edit `wwwroot/images.json` to add metadata for your images:

```json
[
  {
    "filename": "my-image.jpg",
    "title": "Beautiful Sunset",
    "description": "A stunning sunset over the mountains",
    "tags": ["nature", "sunset", "mountains"],
    "dateCreated": "2024-01-15T00:00:00Z"
  }
]
```

## Development

```bash
# Run locally
dotnet run

# Build for production
dotnet publish -c Release
```

## Deployment

This project is configured for automatic deployment to GitHub Pages. When you push to the main branch, GitHub Actions will:

1. Build the Blazor WebAssembly project
2. Publish the static files to the `gh-pages` branch
3. Deploy to GitHub Pages

## Tech Stack

- **Blazor WebAssembly**: .NET 9.0
- **Bootstrap 5**: Responsive UI framework
- **Bootstrap Icons**: Icon library
- **GitHub Pages**: Static hosting

## Browser Support

Modern browsers with WebAssembly support:
- Chrome 57+
- Firefox 52+
- Safari 11+
- Edge 16+

---

Built according to the specifications in [PRD.md](PRD.md).