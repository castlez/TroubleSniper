# TroubleSniper
#####Copyright (c) 2016 [Jonathan Castle](http://castlez.github.io)
This software is licensed under "GPL v3" license, please see the file `COPYING` in this distribution for license information

## Description
TroubleSniper is a trouble shooting application for windows 10 with a focus on diagnosing problems with video games. It uses a variety of diagnostic libraries native to C# to collect information about processes, focus, and other information about the system, to assist in the diagnosis of problems with Windows 10.

## Support & Contact

This software is intended for use on the Windows 10 operating systems.

The author can be reached at castlez93@gmail.com

[Issue Tracker](https://trello.com/b/9K0MreL6/troublesniper)

Please file issues on the github repo, and they will be added to Trello at the authors discretion.

### How to Launch & Use

Locate the executable file called "TroubleSniper.exe" (currently this executable is in the "TroubleSniper\TroubleSniper\bin\Debug" directory). Upon launching the application, you will see a series of diagnostic mini-apps that can be launch simultaneously. These mini-apps each track a specific activity on your computer and report information about that activity to assist in finding causes of, and solutions to, the problem.

### How to Contribute

See the [instructions for adding mini-apps](/TroubleSniper/ADDINGMINIAPPS.txt)

## Current Mini-Apps
#### 1. FocusFinder

Reports changes in focus between processes. Can be used to diagnose random focus changes, and invisible windows changing focus. Common problems this can help with include a random focus change to desktop when trying to play a game.

#### 2. ProcessParents

Lists running processes and their parent process (process that launched it). Used to find the origin of mysterious window and dialogues.

## Future Mini-Apps  
These are mini-apps I intend on implementing in the future. Let me know if you want one of them sooner and I can either implement it or help you implement it!  

#### 1. SeeInTM
SeeIn(T)ask(M)anager. A service that adds an option to every windows context menu (specifically the top bar with exit, minimize and window size) to view the program in task manager's detail view. Can be helpful when a window doesnt have a title or the title is different than what it is called in task manager.
