# HanNoonAR
Capstone Design AR Application at Gachon University

## Introduction
HanNOON is an android application that helps users find out what stores sell
In the past, in order to choose a restaurant in a food alley when many restaurants are gathered, we had to walk around or search through web search and read the text.
But, if we use what we are trying to make, we can identify the restaurant’s representative menu and rating at a glance through the 3D model.
And we can be guided in front of the restaurant by following the 3D model.

## Diagram
<img width="400" alt="스크린샷 2023-06-14 오후 11 57 16" src="https://github.com/Bal1oon/HanNoonAR/assets/74820505/017ce242-c346-44be-8239-58a13cad5908">

## Pipeline of Implementation
<img width="400" alt="스크린샷 2023-06-15 오전 12 15 46" src="https://github.com/Bal1oon/HanNoonAR/assets/74820505/0a53a4fa-7fd8-461c-b6ef-841681294edf">

## Installation
**1. Download APK**
* Download the APK file, HanNoon.apk from the [HanNoonAR](https://github.com/Bal1oon/HanNoonAR)

**2. Unity**
* Download Unity.
* Download Unity.
* Download the files from the GitHub repository at [HanNoonAR](https://github.com/Bal1oon/HanNoonAR)
* Launch Unity and execute the Unity packages among the downloaded files.
* In Unity, go to File > Build Settings > Select Android (Platform) > Switch Platform.
* Configure Player Settings:
    * Select 'Android' under the Player Settings.
    * Other Settings > Rendering > Texture compression format > select ETC
    * Other Settings > Rendering > Normal Map Encoding > select XYZ
    * Other Settings > Identification > Minimum API Level > select 26
    * Other Settings > Configuration > Scripting Backend > select IL2CPP
    * Other Settings > Configuration > Target Architectures > unselect ARMv7 and select ARM64
* File > Build And Run
