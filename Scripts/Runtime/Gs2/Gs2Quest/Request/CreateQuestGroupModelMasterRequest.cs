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
using Gs2.Gs2Quest.Model;

namespace Gs2.Gs2Quest.Request
{
	public class CreateQuestGroupModelMasterRequest : Gs2Request<CreateQuestGroupModelMasterRequest>
	{

        /** カテゴリ名 */
        public string namespaceName { set; get; }

        /**
         * カテゴリ名を設定
         *
         * @param namespaceName カテゴリ名
         * @return this
         */
        public CreateQuestGroupModelMasterRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** クエストグループモデル名 */
        public string name { set; get; }

        /**
         * クエストグループモデル名を設定
         *
         * @param name クエストグループモデル名
         * @return this
         */
        public CreateQuestGroupModelMasterRequest WithName(string name) {
            this.name = name;
            return this;
        }


        /** クエストグループマスターの説明 */
        public string description { set; get; }

        /**
         * クエストグループマスターの説明を設定
         *
         * @param description クエストグループマスターの説明
         * @return this
         */
        public CreateQuestGroupModelMasterRequest WithDescription(string description) {
            this.description = description;
            return this;
        }


        /** クエストグループのメタデータ */
        public string metadata { set; get; }

        /**
         * クエストグループのメタデータを設定
         *
         * @param metadata クエストグループのメタデータ
         * @return this
         */
        public CreateQuestGroupModelMasterRequest WithMetadata(string metadata) {
            this.metadata = metadata;
            return this;
        }


        /** 挑戦可能な期間を指定するイベントマスター のGRN */
        public string challengePeriodEventId { set; get; }

        /**
         * 挑戦可能な期間を指定するイベントマスター のGRNを設定
         *
         * @param challengePeriodEventId 挑戦可能な期間を指定するイベントマスター のGRN
         * @return this
         */
        public CreateQuestGroupModelMasterRequest WithChallengePeriodEventId(string challengePeriodEventId) {
            this.challengePeriodEventId = challengePeriodEventId;
            return this;
        }


	}
}