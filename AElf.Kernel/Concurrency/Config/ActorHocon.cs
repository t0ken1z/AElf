﻿namespace AElf.Kernel.Concurrency.Config
{
    public class ActorHocon
    {
        public const string ActorSingleHocon = @"
            akka {
                actor {
                    deployment {
                        /router {
                            router = tracked-group
                        }
                    }
                    router.type-mapping {
                        tracked-group = ""AElf.Kernel.Concurrency.Execution.TrackedGroup, AElf.Kernel""
                    }
                }
            }
        ";

        public const string ActorClusterHocon = @"
            akka {
                actor {
                    provider = cluster
                    deployment {
                        /router {
                            router = round-robin-group
                            routees.paths = [""/user/worker""]
                            cluster {
                                enabled = on
                                max-nr-of-instances-per-node = 1
                                allow-local-routees = off
                                use-role = worker
                            }
                        }
                    }
                    router.type-mapping {
                        tracked-group = ""AElf.Kernel.Concurrency.Execution.TrackedGroup, AElf.Kernel""
                    }
                    serializers {
                        hyperion = ""Akka.Serialization.HyperionSerializer, Akka.Serialization.Hyperion""
                        bytes = ""Akka.Serialization.ByteArraySerializer""
                    }
                    serialization-bindings {
                        ""System.Object"" = hyperion
                        ""System.Byte[]"" = bytes
                    }
                }
                remote {
                    dot-netty.tcp {
                        hostname = ""127.0.0.1""
                        port = 0
                        maximum-frame-size = 300000000b
                        send-buffer-size = 300000000b
                        receive-buffer-size = 300000000b
                        enable-pooling = false
                    }
                }
                cluster {
                    seed-nodes = [""akka.tcp://AElfSystem@127.0.0.1:32551""]
                    roles = [""manager""]
                }
            }
        ";

        public const string ActorWorkerHocon = @"
            akka {
                actor {
                    provider = cluster
                    serializers {
                        hyperion = ""Akka.Serialization.HyperionSerializer, Akka.Serialization.Hyperion""
                        bytes = ""Akka.Serialization.ByteArraySerializer""
                    }
                    serialization-bindings {
                        ""System.Object"" = hyperion
                        ""System.Byte[]"" = bytes
                    }
                }
                remote {
                    dot-netty.tcp {
                        hostname = ""127.0.0.1""
                        port = 32551
                        maximum-frame-size = 300000000b
                        send-buffer-size = 300000000b
                        receive-buffer-size = 300000000b
                        enable-pooling = false
                    }
                }
                cluster {
                    seed-nodes = [""akka.tcp://AElfSystem@127.0.0.1:32551"",""akka.tcp://AElfSystem@127.0.0.1:32552""]
                    roles = [""worker""]
                }
            }
        ";
    }
}