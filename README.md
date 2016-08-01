# TroubleSniper
#####Copyright (c) 2016 Jonathan Castle
This software is licensed under "GPL v3" license, please see the file `COPYING` in this distribution for license information

## Description
TroubleSniper is a trouble shooting application for windows 10 with a focus on diagnosing problems with 
video games. 

[Issue Tracker](https://trello.com/b/9K0MreL6/troublesniper)

## Support
This software is intended for use on the Windows 10 operating systems.

### How to launch & Use
Locate the executable file called "TroubleSniper.exe" in the main directory (currently this executable is in the "TroubleSniper\TroubleSniper\bin\Debug" directory). Upon launching
the application, you will see a series of diagnostic mini-apps that can be launch simultaneously. These mini-apps each track a specific activity on your computer and report information about that activity to assist in 
finding causes of, and solutions to, the problem.


## Current Mini-Apps
#### 1. FocusFinder
Reports changes in focus between processes. Can be used to diagnose random focus changes, and invisible windows
changing focus. Common problems this can help with include a random focus change to desktop when trying to play a game.

#### 2. ProcessParents
Lists running processes and their parent process (process that launched it). Used to find the origin of mysterious windows and dialogues.
