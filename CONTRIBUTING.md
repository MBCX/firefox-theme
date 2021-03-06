# Contributing.
This file will help you about general rules on how to structure your code if you want to build and/or contribute to this theme. Also how to build the theme for VS2019.
<br /> <br />

## For Visual Studio Code.
- **Be verbose**. Each modification inside the .json has a "name" attribute that describes the scope. **If you can**, try to be verbose. For example, _"Modified CSS @media keyword colour"_ is usually OK. But _"Modified the colour for CSS @media to a darker purple"_ is leaps better.

<br>

## Building for Visual Studio 2019.
- **You must instal the "Visual Studio Colour Theme Designer" extension.** [You can get it clicking here.](https://marketplace.visualstudio.com/items?itemName=ms-madsk.ColorThemeDesigner&ssr=false#overview)
- Open the **.sln** inside _vs/vs2019/Firefox Theme_.
- Open any of the .vstheme and start editing! Each edit will modify the file.
- When you're ready to build the theme and test it yourself, build it by clicking Build -> Build Firefox Theme.
- It'll generate a .vsix for you to instal the theme. Before doing so, **I recommend that you remove the theme first.** That way there won't be any overlap and ensures that everything goes as expected. You can do this by going to Extensions -> Manage Extensions -> Instaled and removing "Firefox_Dark"
<br> <br>

_**IMPORTANT NOTE:**_ <br>
_If you're going to make this theme compatible with other versions of Visual Studio, please seperate it in its own folder inside the "vs" folder in the repository._