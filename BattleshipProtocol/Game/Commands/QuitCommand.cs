﻿using System;
using BattleshipProtocol.Protocol;

namespace BattleshipProtocol.Game.Commands
{
    public class QuitCommand : ICommandTemplate
    {
        /// <inheritdoc />
        public string Command { get; } = "QUIT";

        /// <inheritdoc />
        public void OnCommand(BattleClient context, string argument)
        {
            // TODO: Close connection
            // TODO: Send 270
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public void OnResponse(BattleClient context, Response response)
        {
            // TODO: Is 270? Then close connection
            throw new NotSupportedException();
        }
    }
}