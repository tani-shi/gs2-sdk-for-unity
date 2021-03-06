/*
 * Copyright 2016 Game Server Services, Inc. or its affiliates. All Rights
 * Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using Gs2.Core.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Version.Model
{
	[Preserve]
	public class CurrentVersionMaster
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public CurrentVersionMaster WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }

        /** マスターデータ */
        public string settings { set; get; }

        /**
         * マスターデータを設定
         *
         * @param settings マスターデータ
         * @return this
         */
        public CurrentVersionMaster WithSettings(string settings) {
            this.settings = settings;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.namespaceName != null)
            {
                writer.WritePropertyName("namespaceName");
                writer.Write(this.namespaceName);
            }
            if(this.settings != null)
            {
                writer.WritePropertyName("settings");
                writer.Write(this.settings);
            }
            writer.WriteObjectEnd();
        }

    	[Preserve]
        public static CurrentVersionMaster FromDict(JsonData data)
        {
            return new CurrentVersionMaster()
                .WithNamespaceName(data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString() : null)
                .WithSettings(data.Keys.Contains("settings") && data["settings"] != null ? data["settings"].ToString() : null);
        }
	}
}