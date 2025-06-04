# NotesApp - Visual Studio Extension

A simple and lightweight Visual Studio extension that provides a dedicated Notes tool window for developers to quickly jot down thoughts, reminders, and code snippets directly within the IDE.

## Features

- **Integrated Notes Tool Window**: Access your notes without leaving Visual Studio
- **Easy Access**: Notes window available from the Visual Studio Window menu
- **Lightweight**: Minimal resource usage with clean, simple interface
- **Visual Studio Integration**: Seamlessly integrated into the Visual Studio IDE experience

## Requirements

- **Visual Studio**: 2014 or later
- **.NET Framework**: 4.5 or higher
- **Operating System**: Windows (Visual Studio supported versions)

## Installation

### From VSIX Package
1. Download the latest release from the [Releases](../../releases) page
2. Close Visual Studio if it's running
3. Double-click the `.vsix` file to install
4. Restart Visual Studio
5. The Notes tool window will be available in the **Window** menu

### From Source
1. Clone this repository
2. Open `NotesApp.sln` in Visual Studio
3. Build the solution (Build > Build Solution)
4. The compiled VSIX package will be in the `bin\Debug` or `bin\Release` folder
5. Install the generated `.vsix` file

## Usage

1. **Open Notes Window**: 
   - Go to **Window** menu in Visual Studio
   - Click on **Notes** to open the tool window

2. **Using the Notes Window**:
   - The Notes tool window will appear as a dockable panel
   - Currently features a simple interface for basic note functionality
   - Click the "Click Me!" button to test the functionality

## Development

### Prerequisites for Development
- Visual Studio 2014 or later with Visual Studio SDK installed
- .NET Framework 4.5 development tools

### Project Structure
```
NotesApp/
├── NotesApp/               # Main extension project
│   ├── NotesAppPackage.cs  # Main package class
│   ├── MyToolWindow.cs     # Tool window implementation
│   ├── MyControl.xaml      # UI for the notes window
│   ├── NotesApp.vsct      # Visual Studio command table
│   └── Resources/          # Icons and resources
├── NotesApp.sln           # Solution file
└── README.md              # This file
```

### Building the Extension

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/prasethu/NotesApp.git
   cd NotesApp
   ```

2. **Open in Visual Studio**:
   - Open `NotesApp.sln` in Visual Studio
   - Ensure you have the Visual Studio SDK installed

3. **Build**:
   - Select Debug or Release configuration
   - Build > Build Solution (or press Ctrl+Shift+B)

4. **Debug/Test**:
   - Press F5 to launch a new experimental instance of Visual Studio
   - The extension will be loaded in the experimental instance for testing

### Key Components

- **NotesAppPackage.cs**: Main extension package that handles initialization and command registration
- **MyToolWindow.cs**: Implements the tool window functionality
- **MyControl.xaml/.cs**: Defines the user interface and interaction logic for the notes panel
- **NotesApp.vsct**: Visual Studio Command Table that defines menu integration

## Contributing

Contributions are welcome! Here's how you can help:

1. **Fork the Repository**: Click the Fork button at the top of this page
2. **Create a Feature Branch**: 
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. **Make Your Changes**: Implement your feature or bug fix
4. **Test Thoroughly**: Ensure your changes work in both Debug and Release builds
5. **Commit Your Changes**: 
   ```bash
   git commit -am "Add your descriptive commit message"
   ```
6. **Push to Your Fork**: 
   ```bash
   git push origin feature/your-feature-name
   ```
7. **Submit a Pull Request**: Open a PR with a clear description of your changes

### Development Guidelines
- Follow existing code style and conventions
- Test your changes in an experimental Visual Studio instance
- Update documentation if you add new features
- Ensure compatibility with Visual Studio 2014+

## Future Enhancements

Potential improvements for future versions:
- Rich text editing capabilities
- Note persistence and saving
- Multiple note tabs or categories
- Search and organization features
- Import/export functionality
- Syntax highlighting for code snippets

## License

This project is open source. Please check the repository for license details.

## Support

If you encounter any issues or have questions:
- Open an [Issue](../../issues) on GitHub
- Check existing issues for solutions
- Provide detailed information about your environment and the problem

---

**Note**: This extension is a work in progress. Current functionality includes basic tool window integration with plans for expanded note-taking features in future releases.