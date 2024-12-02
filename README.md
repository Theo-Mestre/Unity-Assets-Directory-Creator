# Unity Assets Directory Creator

**Assets Directory Creator** is a package made for Unity 6 to allow quick way to create directories and assets in Unity.

![image](https://github.com/Theo-Mestre/Unity-Assets-Directory-Creator/blob/main/ReadMeAssets/AssetsDirectoryCreator.gif)

## Features

- **Directory Selection** <br>
Choose the folder you want to add to your project directory.
If you select the Scripts or Materials directories, you can immediately create new scripts or materials within them.

- **Optimized Workflow for Bulk Operations** <br>
When creating multiple directories or assets, you can disable the Reload Domain On Save toggle to skip the automatic reload.
This allows for faster asset creation without interruptions. Note that the new assets will only appear after the domain is reloaded manually.

- **Customizable Settings** <br>
Adjust settings such as the working directory and default folder paths through the AssetsCreatorSettings scriptable object.
You can create additional AssetsCreatorSettings objects (`Create->AssetsCreator->Settings`) if different configurations are required for specific projects.

![image](https://github.com/user-attachments/assets/8d3e10b1-df87-40ed-969e-fafaca6efd2a)

- **Script Templates** <br>
Extend functionality by adding more script templates (`Create->AssetsCreator->ScriptTemplate`) in a `Resources/ScriptTemplates` directory.
Use `{ClassName}` placeholders in your templates, which will be automatically replaced with the desired class name when creating new scripts.

![image](https://github.com/user-attachments/assets/21cda0c8-ea09-455d-a09e-7617c265ff7e)


## Installation

In order to use **Assets Directory Creator**, you can import the Unity Package available in [Releases](https://github.com/Theo-Mestre/Unity-Assets-Directory-Creator/releases)

You can also download the sources and drop them in your project Assets folder.

## System Requirements

Unity 6000.0.23f1 or newer

It might work on older version but I didn't tested it.
