﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AElf.Cryptography.ECDSA;
using AElf.ChainController;

namespace AElf.Kernel.Node
{
    public interface IAElfNode
    {
        bool Start(ECKeyPair nodeKeyPair, bool startRpc, int rpcPort, string rpcHost, string initData, byte[] code);
        
        Task<BlockExecutionResult> ExecuteAndAddBlock(IBlock block);

        Task ReceiveTransaction(byte[] messagePayload, bool isFromSend);

        Task<ulong> GetCurrentChainHeight();
        
        BlockProducer BlockProducers { get; }
        
        Hash ContractAccountHash { get; }

        IDisposable ConsensusDisposable { get; set; }

        ulong CurrentRoundNumber { get; set; }

        // ReSharper disable once InconsistentNaming
        Task CheckUpdatingDPoSProcess();
        
        int IsMiningInProcess { get; }
    }
}