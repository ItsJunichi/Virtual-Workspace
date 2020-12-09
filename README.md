# Virtual-Workspace
Virtual workspace that students can work remotely from and chat with eachother!

# How to use

After cloning and opening the project ( Works best with version 2020.1.4f1 ) make sure you first reimport all assets. Some Scenes might not work properly without reimporting the assets. The next thing you should do is open the "NetworkManager" from the hierarchy, and make sure the online scene is set to the "Game" scene. Next up check what the current "Network Address" is on the Manager. For local testing, you can just set it to localhost, but in order to test the project over network, you need to change this to, for example you'r own IP address. Also when hosting a server, make sure the port is set to a port that is currently opened in your network.

After that everything should be ready. Just go ahead and build the project like any other, with the Game scene in the build settings. You can either test the project by opening 2 builds on your own PC, or you can pass the builds folder to a friend. Now the user who has their IP on the project can host the server by clicking the "Server + Client" button on the network HUD. After the server is running, other users can join as clients using your ip and port

Example formatting to connect: "145.10.45.1:7777" where 145.10.45.1 is the IP, and 7777 is the port

