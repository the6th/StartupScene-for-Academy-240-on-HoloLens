## This is [Holograms 240](https://developer.microsoft.com/ja-jp/windows/holographic/holograms_240) Add-on.
## Anytime you can change sharing settings on your HoloLens.

# Overview
[Holograms 240](https://developer.microsoft.com/ja-jp/windows/holographic/holograms_240)  is a sample project to learn how to develop a HoloLens sharing application on Unity.
it is good sample,but we must build application every time only to change server information (network-ip and port).

This Add-on contain a simple scene to change server information using Air-Tap.
This add-on will save your time.

![Start up scene](External/readmeimage.jpg)

# How to use

1. Open [Holograms 240 project](https://developer.microsoft.com/ja-jp/windows/holographic/holograms_240) as ever.
2. Open \Assets\HoloToolkit-Sharing-240\Sharing\Scripts\SharingStage.cs,and add follow 2 lines on Awake method.
 ```
 ServerAddress = PlayerPrefs.GetString("host");
 ServerPort = int.Parse(PlayerPrefs.GetString("port"));
 ```
3. Import this add-on on your Assets folder.([unitypackage is
here](External/StartupSceneFor240.unitypackage))
4. Open littlewing\StartUp.scene on Unity Editor.
5. Add StartUp scene as first scene.(File -> Build Settings -> Scenes in Build)
6. Build & Deploy and Run.

# License
MIT License.
