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
using Gs2.Core.Control;
using Gs2.Core.Model;
using Gs2.Gs2Experience.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Experience.Request
{
	[Preserve]
	public class UpdateNamespaceRequest : Gs2Request<UpdateNamespaceRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public UpdateNamespaceRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** ネームスペースの説明 */
        public string description { set; get; }

        /**
         * ネームスペースの説明を設定
         *
         * @param description ネームスペースの説明
         * @return this
         */
        public UpdateNamespaceRequest WithDescription(string description) {
            this.description = description;
            return this;
        }


        /** ランクキャップ取得時 に実行されるスクリプト のGRN */
        public string experienceCapScriptId { set; get; }

        /**
         * ランクキャップ取得時 に実行されるスクリプト のGRNを設定
         *
         * @param experienceCapScriptId ランクキャップ取得時 に実行されるスクリプト のGRN
         * @return this
         */
        public UpdateNamespaceRequest WithExperienceCapScriptId(string experienceCapScriptId) {
            this.experienceCapScriptId = experienceCapScriptId;
            return this;
        }


        /** 経験値変化したときに実行するスクリプト */
        public Gs2.Gs2Experience.Model.ScriptSetting changeExperienceScript { set; get; }

        /**
         * 経験値変化したときに実行するスクリプトを設定
         *
         * @param changeExperienceScript 経験値変化したときに実行するスクリプト
         * @return this
         */
        public UpdateNamespaceRequest WithChangeExperienceScript(Gs2.Gs2Experience.Model.ScriptSetting changeExperienceScript) {
            this.changeExperienceScript = changeExperienceScript;
            return this;
        }


        /** ランク変化したときに実行するスクリプト */
        public Gs2.Gs2Experience.Model.ScriptSetting changeRankScript { set; get; }

        /**
         * ランク変化したときに実行するスクリプトを設定
         *
         * @param changeRankScript ランク変化したときに実行するスクリプト
         * @return this
         */
        public UpdateNamespaceRequest WithChangeRankScript(Gs2.Gs2Experience.Model.ScriptSetting changeRankScript) {
            this.changeRankScript = changeRankScript;
            return this;
        }


        /** ランクキャップ変化したときに実行するスクリプト */
        public Gs2.Gs2Experience.Model.ScriptSetting changeRankCapScript { set; get; }

        /**
         * ランクキャップ変化したときに実行するスクリプトを設定
         *
         * @param changeRankCapScript ランクキャップ変化したときに実行するスクリプト
         * @return this
         */
        public UpdateNamespaceRequest WithChangeRankCapScript(Gs2.Gs2Experience.Model.ScriptSetting changeRankCapScript) {
            this.changeRankCapScript = changeRankCapScript;
            return this;
        }


        /** ログの出力設定 */
        public Gs2.Gs2Experience.Model.LogSetting logSetting { set; get; }

        /**
         * ログの出力設定を設定
         *
         * @param logSetting ログの出力設定
         * @return this
         */
        public UpdateNamespaceRequest WithLogSetting(Gs2.Gs2Experience.Model.LogSetting logSetting) {
            this.logSetting = logSetting;
            return this;
        }


    	[Preserve]
        public static UpdateNamespaceRequest FromDict(JsonData data)
        {
            return new UpdateNamespaceRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                description = data.Keys.Contains("description") && data["description"] != null ? data["description"].ToString(): null,
                experienceCapScriptId = data.Keys.Contains("experienceCapScriptId") && data["experienceCapScriptId"] != null ? data["experienceCapScriptId"].ToString(): null,
                changeExperienceScript = data.Keys.Contains("changeExperienceScript") && data["changeExperienceScript"] != null ? Gs2.Gs2Experience.Model.ScriptSetting.FromDict(data["changeExperienceScript"]) : null,
                changeRankScript = data.Keys.Contains("changeRankScript") && data["changeRankScript"] != null ? Gs2.Gs2Experience.Model.ScriptSetting.FromDict(data["changeRankScript"]) : null,
                changeRankCapScript = data.Keys.Contains("changeRankCapScript") && data["changeRankCapScript"] != null ? Gs2.Gs2Experience.Model.ScriptSetting.FromDict(data["changeRankCapScript"]) : null,
                logSetting = data.Keys.Contains("logSetting") && data["logSetting"] != null ? Gs2.Gs2Experience.Model.LogSetting.FromDict(data["logSetting"]) : null,
            };
        }

	}
}