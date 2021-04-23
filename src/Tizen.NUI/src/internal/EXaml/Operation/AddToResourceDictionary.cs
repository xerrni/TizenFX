﻿/*
 * Copyright(c) 2021 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Binding.Internals;

namespace Tizen.NUI.EXaml
{
    internal class AddToResourceDictionary : Operation
    {
        internal AddToResourceDictionary(int instanceIndex, string key, object value)
        {
            this.instanceIndex = instanceIndex;
            this.key = key;
            this.value = value;
        }

        public void Do()
        {
            var instance = LoadEXaml.GatheredInstances[instanceIndex] as ResourceDictionary;
            var realValue = (value is Instance) ? LoadEXaml.GatheredInstances[(value as Instance).Index] : value;

            instance.Add(key, realValue);
        }

        private int instanceIndex;
        private string key;
        private object value;
    }
}
