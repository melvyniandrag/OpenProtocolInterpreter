﻿namespace OpenProtocolInterpreter.Messages
{
    /// <summary>
    /// Templates for parsing packages and validating Mid assignability
    /// </summary>
    public interface IMessagesTemplate
    {
        Mid ProcessPackage(int mid, string package);
        Mid ProcessPackage(int mid, byte[] package);
        bool IsAssignableTo(int mid);
    }
}
