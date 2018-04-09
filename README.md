# Pdb2Mdb-GUI
A GUI tool to convert .NET .pdb files to Mono .mdb files.

![Screenshot](https://i.imgur.com/o3LALE8.png)

# FAQ
### Why does the tool fail on some PDB files with an OutOfMemoryException?
This is some change in the way .NET Core PDB files work. Add these lines to your .csproj to fix:

```xml
<PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
  <DebugType>Full</DebugType>
</PropertyGroup>
```
