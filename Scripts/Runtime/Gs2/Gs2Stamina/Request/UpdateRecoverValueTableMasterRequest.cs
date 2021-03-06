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
using Gs2.Gs2Stamina.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Stamina.Request
{
	[Preserve]
	public class UpdateRecoverValueTableMasterRequest : Gs2Request<UpdateRecoverValueTableMasterRequest>
	{

        /** ネームスペース名 */
        public string namespaceName { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public UpdateRecoverValueTableMasterRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** スタミナ回復量テーブル名 */
        public string recoverValueTableName { set; get; }

        /**
         * スタミナ回復量テーブル名を設定
         *
         * @param recoverValueTableName スタミナ回復量テーブル名
         * @return this
         */
        public UpdateRecoverValueTableMasterRequest WithRecoverValueTableName(string recoverValueTableName) {
            this.recoverValueTableName = recoverValueTableName;
            return this;
        }


        /** スタミナ回復量テーブルマスターの説明 */
        public string description { set; get; }

        /**
         * スタミナ回復量テーブルマスターの説明を設定
         *
         * @param description スタミナ回復量テーブルマスターの説明
         * @return this
         */
        public UpdateRecoverValueTableMasterRequest WithDescription(string description) {
            this.description = description;
            return this;
        }


        /** スタミナ回復量テーブルのメタデータ */
        public string metadata { set; get; }

        /**
         * スタミナ回復量テーブルのメタデータを設定
         *
         * @param metadata スタミナ回復量テーブルのメタデータ
         * @return this
         */
        public UpdateRecoverValueTableMasterRequest WithMetadata(string metadata) {
            this.metadata = metadata;
            return this;
        }


        /** 経験値の種類マスター のGRN */
        public string experienceModelId { set; get; }

        /**
         * 経験値の種類マスター のGRNを設定
         *
         * @param experienceModelId 経験値の種類マスター のGRN
         * @return this
         */
        public UpdateRecoverValueTableMasterRequest WithExperienceModelId(string experienceModelId) {
            this.experienceModelId = experienceModelId;
            return this;
        }


        /** ランク毎のスタミナ回復量テーブル */
        public List<int?> values { set; get; }

        /**
         * ランク毎のスタミナ回復量テーブルを設定
         *
         * @param values ランク毎のスタミナ回復量テーブル
         * @return this
         */
        public UpdateRecoverValueTableMasterRequest WithValues(List<int?> values) {
            this.values = values;
            return this;
        }


    	[Preserve]
        public static UpdateRecoverValueTableMasterRequest FromDict(JsonData data)
        {
            return new UpdateRecoverValueTableMasterRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                recoverValueTableName = data.Keys.Contains("recoverValueTableName") && data["recoverValueTableName"] != null ? data["recoverValueTableName"].ToString(): null,
                description = data.Keys.Contains("description") && data["description"] != null ? data["description"].ToString(): null,
                metadata = data.Keys.Contains("metadata") && data["metadata"] != null ? data["metadata"].ToString(): null,
                experienceModelId = data.Keys.Contains("experienceModelId") && data["experienceModelId"] != null ? data["experienceModelId"].ToString(): null,
                values = data.Keys.Contains("values") && data["values"] != null ? data["values"].Cast<JsonData>().Select(value =>
                    {
                        return (int?)int.Parse(value.ToString());
                    }
                ).ToList() : null,
            };
        }

	}
}