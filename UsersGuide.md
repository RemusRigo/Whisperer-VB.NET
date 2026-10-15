# Whisperer: User's Guide

> Whisperer is **in progress**: some categories in the tree are still empty.



## Downloads & Runtimes

Download the latest release from the [Releases page](https://github.com/RemusRigo/Whisperer-VB.NET/releases).

|Folder|Target Framework|Architecture|Required Runtime|
|-|-|-|-|
|`Release`|.NET 10.0|Any CPU|[.NET 10.0 Desktop Runtime](https://dotnet.microsoft.com/download/dotnet/10.0)|

> The plain ".NET Runtime" is not enough; Whisperer needs the **Desktop** Runtime.
> To check which runtimes are installed, run `dotnet --list-runtimes` and look for a `Microsoft.WindowsDesktop.App 10.x` line.



## Install

Whisperer is portable: there is no installer.

1. Download and extract the release to a folder, for example `D:\My Apps\Whisperer\`.
   Keep all the files together: `Whisperer.exe` needs `libUtilities.dll`, `libSW.dll`, `libVM.dll` and `libWindows.dll`.
2. Right-click `Whisperer.exe` → **Run as administrator** (needed for the *All Users* settings).
   The status bar shows whether Whisperer runs with administrator rights.

> If Windows blocks the file ("Windows protected your PC"), right-click `Whisperer.exe` →
> **Properties** → check **Unblock** → **OK**, then try again.



## Usage

Double-click a category in the tree on the left; its settings are shown on the right.
After an action, the status bar shows how long it took.
Right-click the window → **About** for version information.

### Microsoft Windows → AI

Check the options you want, then click **Run**:

* Disable Copilot
* Disable Recall
* Disable Cortana
* Disable Bing/Web Search
* Disable Search Suggestions
* Disable Search access Location
* Disable Search access Store
* **Remove AI features from:** Notepad, Paint

### Microsoft Windows → TaskBar

|Tab|Setting|
|-|-|
|**Current User**|**SearchBox**: how Search is shown on the taskbar; **Show Widgets**|
|**All Users**|**Disable Widgets** (needs administrator rights)|

### Microsoft Windows → Theme

|Setting|Options|
|-|-|
|**Apps**|Dark, Light|
|**System**|Dark, Light (taskbar, Start menu)|

Some changes take effect only after you restart File Explorer or sign out and in again.



## Uninstall

Delete the folder you created in step 1 of *Install*. Whisperer doesn't write its own settings.
