# Poacher-Protection Survival Game 

## General Requirements
- Playstation 4 Controller
- Unity Hub must contain 2019.4.10f1 version of Unity. If this version is not currently available,when you locate the project repo for the first time in Unity Hub, it will ask you to install this version of Unity. 
- When installing, if necessary, add modules Adroid Build Support and IOS Build Support to the Unity Version.

## MacOs Requirements
- Xcode 12 (or most recent version)
- IOS Device (Iphone X or newer)

## MacOs / iOS Build Steps
1. Clone the repo or download the zipfile and unzip it 
2. Open Unity Hub and locate the project to add it to your project list
3. Open the project in Unity. 
4. Navigate to File > Build Settings
4.1. If the Unity Icon does not appear next to IOS, toggle IOS and click "Switch Platform" Skip otherwise
5. Press 'Build' and save project in your home directory as "Build1" (what I used) or some unused name.
... Wait ... 
5. Open the directory in XCode. 
6. Plug in an IPhone or other IOS Device and wait for it to register. On the Top of the screen will say Unity-Iphone -> IPhone (or corresponding name of your device)
7. Navigate to Unity-IPhone > Targets > Unity-IPhone. 
8. Click 'Automatically manage signing" and enter a field for "Team" once it comes up. 
9. Click the '>' Play Button symbol at the top of the screen. Wait. Ignore the Warnings. (There are 999+ on my machine)
10. Enter password if prompted. 
11. On IPhone, navigate to Settings > General > Device Management and click through until you can acknowledge that you trust us. You trust us, don't you? 
11. The application is now live on Iphone. 
12. While the application is open, Strap in the phone to Google VR, connect corresponding control and begin gameplay. 

## Windows / Android Build Steps
1. Clone the repo or download the zipfile and unzip it 
2. Open Unity Hub and locate the project to add it to your project list
3. Open the project in Unity. 
4. Navigate to File > Build Settings
5. If Unity icon does not appear next to Android, toggle Android and click "Switch platform". This step can be skipped if Unity icon appears next to Android
6. Press build and choose location other than Unity folder to build the apk to.
... Wait ... 
7. Once build is complete, connect Android phone to Windows and toggle "File Transfer" in usb connection options on Android phone.
8. A file explorer should appear in Windows, if it doesnt open a new file explorer window and navigate to android device.
9. Open a new file explorer and navigate to where the apk was build.
10. Copy over apk file to any folder inside android phone. For this example we will use downloads folder.
11. Using android phone, open the app files and navigate to the downloads folder. 
12. Locate the apk and press it.
13. Android might ask you to change sending in order to install apps from third party sources. If asked, enable installation from third party sources.
14. Finish installing the apk to Android phone.
15. Locate installed app in apps drawer, app should have the name EnvironmentVR and would have a Unity icon.
16. Run the application
17. While the application is open, Strap in the phone to Google VR, connect corresponding control and begin gameplay. 
