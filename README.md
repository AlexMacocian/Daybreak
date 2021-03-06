# Daybreak
Custom client for Guildwars.
Requires webview2 runtime https://go.microsoft.com/fwlink/p/?LinkId=2124703.

![Showcase 1](https://media1.giphy.com/media/Z32o0OZ5pZHDOIodzD/giphy.gif)
![Showcase 2](https://media0.giphy.com/media/aQ8Wl7lsuhT0AblCPI/giphy.gif)
![Showcase 3](https://media2.giphy.com/media/s06PtxgeAAZtoJhTx6/giphy.gif)
![Build Management Showcase](https://media2.giphy.com/media/C399pwfypdZvkmoJpi/giphy.gif)
![Dynamic build loading](https://media2.giphy.com/media/UKtJaoBk6NeuOmE8al/giphy.gif)

# Features
Automatically detect if guildwars is running or not. Includes the ability to launch guildwars from the client.

Multibox support.

Manages multiple username and password combinations.

Manages multiple executables.

Ability to set a character name which gets autoloaded during launch.

Embedded browser set on useful pages or links.

Ability to set default page for each of the two browser windows.

Rotates screenshots from "Screenshots" folder. If no screenshots are present in the folder, downloads and rotates images from http://bloogum.net/guildwars (link to page is visible when showing images from the website).

Manages build templates. Load/save builds from the guildwars build folder. Ability to dynamically load build templates from the embeded browsers. Opens embeded browser for professions, attributes and skills when selected.

Screen placing/binding. If enabled, places guildwars executable on desired screen at launch.

Shortcut management. Can manage automatically shortcuts to desired folder.

# Examples/Usage

## Settings.
To modify any settings, press the settings button on the titlebar
![Settings button](https://i.imgur.com/0QSTvNF.png)

## Settings categories.
To adjust functionality, choose one of the settings categories
![Settings categories](https://i.imgur.com/LtPDvHY.png)

## Using the embeded browsers.
When in the main view, the browsers open the default/prefferred page. To change the prefferred page, navigate to it using one of the browsers and press the star button. The current loaded page will become the default for the selected browser. Preffered page can also be selected from settings.
![Browser default selection](https://i.imgur.com/nDnyIIL.png)

## Displaying screenshots
To display other images than the ones retrieved from "http://bloogum.net/guildwars", place images in the Screenshots folder, next to the Daybreak.exe executable. If the folder doesn't exist yet, either create it or run the launcher once so that it gets created automatically.

## Account management
To adjust accounts, go into account settings. Clicking on the star next to an account sets it as the current account.
![Account settings](https://i.imgur.com/Pwycwwr.png)

## Guildwars executable management
To adjust executables, go into Guildwars settings. Clicking on the star next to the executable path sets it as the current executable.
![Guildwars settings](https://i.imgur.com/XChX19t.png)

## Multibox/Multilaunch support
To enable multiboxing (multi-launch), go into Experimental settings. Then, switch between executables/accounts and launch them.
![Multibox toggle](https://i.imgur.com/vEFF2pb.png)

## Build management / Template management
To manage builds, go into Settings, Builds. Here you can select/remove builds.
![Builds list view](https://i.imgur.com/OFxnFcZ.png)

## Build editor
Doubleclick on one of the builds to enter the template management view. Here you can click on skills to open the wiki page of the skill. You can adjust professions, attributes and add/remove skills.
![Builds management view](https://i.imgur.com/exKWJb8.png)

## Dynamically load build from browser
To dynamically load a build, while browsing in the browsers from the main page, select and rightclick any text on the page that might be a template. If it is a template, the client will open a context menu with a button called "Load build template". Click on that button to load the build and switch to build template view.

![Dynamically load build](https://i.imgur.com/V5vvgsg.png)

## Screen selection/binding
To launch the guildwars executable to a specific screen, open Settings, Launcher Settings either fill in the "Desired screen id",
![Screen selection](https://i.imgur.com/j6PJnvm.png)
or use the selection view. If you press Test button on screen selection view, it will automatically move the currently running guildwars to the selected screen.
![Screen selection view](https://i.imgur.com/gTeCnM0.png)

## Shortcuts
To manage launcher shortcuts, use the Settings, Launcher Settings menu. If you want a different folder than the desktop, use the "Shortcut folder" setting to change to the desired place. By toggling "Shortcut placed" toggle, a shortcut will be created/deleted.
![Shortcut settings](https://i.imgur.com/AF6LX9B.png)
