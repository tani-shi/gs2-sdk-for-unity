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
using Gs2.Core.Control;
using Gs2.Core.Model;
using Gs2.Gs2Formation.Model;

namespace Gs2.Gs2Formation.Request
{
	public class CreateNamespaceRequest : Gs2Request<CreateNamespaceRequest>
	{

        /** ネームスペース名 */
        public string name { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param name ネームスペース名
         * @return this
         */
        public CreateNamespaceRequest WithName(string name) {
            this.name = name;
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
        public CreateNamespaceRequest WithDescription(string description) {
            this.description = description;
            return this;
        }


        /** キャパシティを更新するときに実行するスクリプト */
        public ScriptSetting updateMoldScript { set; get; }

        /**
         * キャパシティを更新するときに実行するスクリプトを設定
         *
         * @param updateMoldScript キャパシティを更新するときに実行するスクリプト
         * @return this
         */
        public CreateNamespaceRequest WithUpdateMoldScript(ScriptSetting updateMoldScript) {
            this.updateMoldScript = updateMoldScript;
            return this;
        }


        /** フォームを更新するときに実行するスクリプト */
        public ScriptSetting updateFormScript { set; get; }

        /**
         * フォームを更新するときに実行するスクリプトを設定
         *
         * @param updateFormScript フォームを更新するときに実行するスクリプト
         * @return this
         */
        public CreateNamespaceRequest WithUpdateFormScript(ScriptSetting updateFormScript) {
            this.updateFormScript = updateFormScript;
            return this;
        }


	}
}