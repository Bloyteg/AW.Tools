﻿// Copyright 2013 Joshua R. Rodgers
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ========================================================================

using System.Runtime.Serialization;
using MrByte.Math;

namespace MrByte.RWX.Model.Components
{
    [DataContract]
    public class Vertex
    {
        public Vertex()
        {
            Position = new Vector3();
        }

        [DataMember]
        public Vector3 Position { get; set; }

        [DataMember]
        public UV UV { get; set; }

        [DataMember]
        public Color Prelight { get; set; }

        [DataMember]
        public Vector3 Normal { get; set; }
    }
}
