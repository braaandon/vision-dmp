ilspy decomp. of "Vision" protected with Oreans Themida by "woof" and "bruce"

some of the code is broken as a result of ilspys decompilation, however if you really wanted to fix it you could

things of note:

discord token stealer - https://github.com/braaandon/vision-dmp/blob/639037cb866b4d85ede28ff54fc8e4e23bb8db9f/Discord.cs#L13

this is, admittedly, never called

anti crack (proc check that sends them your ip address) - https://github.com/braaandon/vision-dmp/blob/639037cb866b4d85ede28ff54fc8e4e23bb8db9f/Vision_Client/BruceVision.cs#L39

this, contrary to their statement, is not required by their third-party authentication service, nor is sending the users assumed Postal Code, Longitude and Latitude but its nice to lie isnt it :D

this entire folder (which is just github.com/braaandon/nlsetup) - https://github.com/braaandon/vision-dmp/tree/main/Vision_Client/limiter

this was supposed to not have been used in this project according to woof himself who messaged me apologising after using it initially in his "NetLimiter++" which he gave to people who had boosted his discord server:

https://imgur.com/a/5z7tN6T
https://imgur.com/a/MZcsAbl

he proposes to accredit the person whose code he uses in his next project (which is still me), which turns out to be vision, but then doesnt, accuses me of lying about the fact he logs peoples information if they have a debugger open by stating that its a requirement of their third-party auth library and then accuses me of intentionally lying about all of this to hurt his reputation


