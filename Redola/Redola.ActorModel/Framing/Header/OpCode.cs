﻿namespace Redola.ActorModel.Framing
{
    // The opcode denotes the frame type of the Actor frame.
    // The opcode is an integer number between 0 and 15, inclusive.
    // Opcode 	Meaning 	Reference 
    // 1	Hello Frame	
    // 2	Welcome Frame
    // 3	Ping Frame
    // 4    Pong Frame
    // 5	Where Frame
    // 6    Here Frame
    // 7    Binary Frame
    // 8-15	Unassigned
    public enum OpCode : byte
    {
        Hello = 1,
        Welcome = 2,
        Ping = 3,
        Pong = 4,
        Where = 5,
        Here = 6,
        Binary = 7,
    }
}
