Monster Hunter Online - Server
===
Server emulator for the game Monster Hunter Online.

# Disclaimer
The project is intended for educational purpose only.

# Server
use the following parameters: `service start` to start the server

# Client
All information is based on Version: `2.0.11.942`  
To run the client please refer to:
https://github.com/sebastian-heinz/mho_luncher

# Hosts
```
127.0.0.1 tqos.gamesafe.qq.com
127.0.0.1 down.qq.com
127.0.0.1 stat.iips.qq.com
127.0.0.1 ied-tqos.qq.com
127.0.0.1 apps.game.qq.com
```

# Connections
## port 7533/UDP and 7534/TCP
Client will send out UDP packets on port 7533 every second.
This packet contains a TCP port number (default 7543), on which the client listens.
Connecting to this port via TCP Socket causes the game client to send data packets.
From my investigation this looks to be used for a `Scaleform AMP` client, a performance anlysis tool.

## port 8081/UDP (tqos.gamesafe.qq.com)
Looks to be anti cheat based communication

## port 8000/UDP (ied-tqos.qq.com )
Looks to be system / log information based communication
  
  
### Branch Properties  
Added a data.csv thats used to add properties to the player when "init" is typed in the chat, and output.csv which contains most of the teleport points for the server to reference. stage.txt forces the server to teleport you to that stage ID on fast travel, but it seems to only work for tutorial and hub areas  

Main purpose of the branch was to try to add the handler for warp points, if you do "print" in chat in meze for example it'll go through the process and take you to the cat area. Actually going to the zone trigger seems to stil bug howver
