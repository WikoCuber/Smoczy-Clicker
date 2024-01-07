# Introduction
Smoczy Clicker is a set of scripts to Minecraft 1.8 EasyHC servers.

# Technologies used
- .NET 8
- Windows Froms
- Some Windows Libs

# Getting Started
First download the newest version form [relese tab](https://github.com/WikoCuber/Smoczy-Clicker/releases). Then install .NET 8 Desktop Runtime. You can download this from [here](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or open an app (if you don't have installed runtime you will get a message with link to download). 

# Usage
## Config
First you need to go into "Binds in MC" tab and sets your binds from MC to correct inputs.

![binds in MC](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/73e35291-0e24-40f5-9969-ae1352d80041)

Then run Minecraft in resolution and settings how you playing normally. Open any world and put double chest there. Open it. Then back to Clicker and go into "Settings" tab. Click the "upper-left slot" button. Back to MC window and move cursor on first slot in chest and click F12. Do the same with "bottom-right slot". (Important! When you click Escape, coordinate capturing will stop, so first open chest, then click the button in clicker).

![settings page](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/e3c575fe-f8b1-4b86-8a44-15bf45433b9b) 
![chest](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/6db188bf-2af0-434d-88f7-65ce4122dd09)

## Basic information
### Active status
All scripts has activation status (✓ or X). Script will work only in active status. To toggle status just click on the symbol. 

![inactive status](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/1ea95004-2531-49f2-be9f-90f913d54b01)
![active status](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/111c5285-912e-4a13-826c-57109ca17eaf)

### Script bind
Every script has bind button. This is the key to run (and stop) script. To change this, click the button and press required key.

![bind button](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/4acbee46-b3cb-4752-b22b-660ac6d7f0e2)

### Script delay
Some scripts has delay setting. It slow down or speed up script (adjust it to your computer and internet connection). 

![delay button](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/2162d77d-a828-47b3-9e17-2ac12d4e9e56)

## Scripts usages
### Macro
Macro is a script that spams left or right mouse button. CPS (Clicks Per Second) determines how many clicks script does in a second.
Macro has 3 capture types:
- OC (One Click) - script starts when key pressed and stops when pressed again
- PC (Press Click) - scripts starts when key is in down and stops when key is relesed
- DH (Down Hold) - scripts starts when key is in down and mouse button is down too, stops when mouse button is relesed

![macro](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/461c0a6f-4e74-41e6-9e4e-d892cb5a69be)

### Armor changing
Armor changing scripts switches armor that you wearing with armor in your EQ. Each script change armor with other slots in your EQ (see images below). It will work only when coordinates is correctly configured.

![armor](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/95c92b25-ad2b-42db-9d33-7ae6d09f7c97)
![eq](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/ba6717f3-792a-438d-a5b5-0777fcff588f)

### Snowball / Fishing rod
Snowball / Fishing rod scripts basically do the same thing. It switching your holding item to proper slot (with snowball or fishing rod) and throw them. Then it switch holding item back to sword.

![snowball / Fishing rod](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/b8a9ed8b-b436-4562-af60-83335b53ced9)

### Mining
Mining as the name suggest is a script which mining stone on a stone generators. Your room to mining must have 2 blocks width and correctly set length. Room on image below has lenght sets to 9. Stone generators are placed on the top with 5 blocks length. 

![mining room](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/1d3a5389-0afc-47cc-bc83-68695703c157)
![length clicker](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/b361a84c-e90f-4ed1-8491-8909621441d8)

To start mining you have to go to the left corner, take a pickaxe and start script.

![room corner](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/9758d886-a356-49b1-953f-cebf0ebc87f4)

You can set the commands that script execute on a given lap. When commands or binds are executed too fast increese command delay in settings page. Binds work similarly, but the script doesn't open chat, it just clicks on the given key. To add new field just click "Add" button. To remove, click on the field while holding Control.

![commands](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/77c7667d-fb63-4713-8ccc-64c3ed731264)
![binds](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/28fe9573-d818-46b2-908d-39f5b82f174d)

You can turn eating on. It eats food on a given lap. 

![eating](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/6c233b9d-62b8-47cb-8beb-7e86c75f3167)

Drop setting drops items into hopper in wall behind right corner. 

![drop place](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/639134f3-5cfd-4388-83a4-6dca4a3ab92e)

When you using drop, pickaxe slot should be last. Images belows shows which slots will be droped. Activated items should be in a row. For example first and second item active is allowed, but first and third isn't.

![drop mining](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/a2b86d6f-617d-4ac3-99ac-8dfa08226511)
![drop slots](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/fa7599f1-4532-453e-a719-58e507b1213e)

To mine in background you need a Minecraft other than Blazing Pack (Optifine, Lunar and Vanilla was tested) in non fullscreen mode. Move Clicker window more or less to screen center. In game click F3 + P once (it will disable showing menu after you exit an window). Start script normally. With Alt + Tab switch window to Clicker and from there you can click Win + D (it will go to desktop). When commands are not typing correctly increese background delay in settings page.

### Deposit dropping 
Deposit dropping is a script that spams drop slot. To stop, click again the key.

![deposit](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/17b50589-b621-481a-bd8b-156da527c31c)

### Drawing / Effects
Drawing / Effects scripts basically do the same thing. It opens a menu with effects or deopsit and click slot on a give coordinates.

![drawing / effects](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/a67eb5ab-10e2-45a3-8b85-23b44c268f60)

### Mathew
Mathew is a script that mining and going straight from underground to top. You can choose your pickaxe type. To stop, click again the key.

![mathew](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/44634cc6-3a8a-46de-a468-eb1574cab79e)

### Alting
Alting is a script that freeze your window to freeze your character in place. Don't click into freezed window. It can crash your game. To stop, click again the key. 

![alting](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/a143130d-b961-495a-be50-f61ab991346d)

### Void
Void is a script that open void (/otchlan) and drops everything. Intelligent checkbox determines is script supposed to drop only black item (works only in non fullscreen mode, so you may change your coordniate settings). Texture pack for intelligent void is in your exe file.

![void](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/8348893c-2a42-423e-a8b7-d7e5427dfdda)

### Dabing 
Dabing is a script that spams or holds a dab key (dependent on a chosen type). To stop, click again the key.

![dabing](https://github.com/WikoCuber/Smoczy-Clicker/assets/98224818/d761facd-afd1-490a-a333-8dfe7b7f239d)

## Adding new item to intelligent void
In default texture pack to intelligent void I put some needed items, but maybe you want to add or remove something. First open directory with textures and go into assets\minecraft\textures. Some items has '!' before the name. You can remove this and the item will be displayed as black. And vice versa you can add '!' before the name and item will be displayed normally. If you want to add new item that aren't in directories then copy one of the texture and rename it to needed name. You can use [this](https://www.curseforge.com/minecraft/texture-packs/template-resource-pack/files/4370838) template to search which name item should has and in which directory it should be.

# Contributors
Po prostu Jakub - made UI images and logo

# Save file
Save file is in JSON format and is located at %appdata%/Smoczy Clicker/save.json. You shouldn't change anything in that.

