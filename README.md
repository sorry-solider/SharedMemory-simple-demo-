# SharedMemory simple demo 
A small demo that uses shared memory methods to communicate between python and c#

send.py is a simple script that loops 1 to 10 into a shared memory space.

recive-data.cs This script can be used to read data from the shared memory space and control the model display switch based on the data read.

How to deploy: in unity, attach recive-data.cs to the component and add the desired switch model to the Models list. Run both unity and python scripts.
