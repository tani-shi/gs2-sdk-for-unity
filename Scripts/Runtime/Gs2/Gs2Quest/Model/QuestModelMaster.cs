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

namespace Gs2.Gs2Quest.Model
{
	[Preserve]
	public class QuestModelMaster
	{

        /** クエストモデルマスター */
        public string questModelId { set; get; }

        /**
         * クエストモデルマスターを設定
         *
         * @param questModelId クエストモデルマスター
         * @return this
         */
        public QuestModelMaster WithQuestModelId(string questModelId) {
            this.questModelId = questModelId;
            return this;
        }

        /** クエストグループモデル名 */
        public string questGroupName { set; get; }

        /**
         * クエストグループモデル名を設定
         *
         * @param questGroupName クエストグループモデル名
         * @return this
         */
        public QuestModelMaster WithQuestGroupName(string questGroupName) {
            this.questGroupName = questGroupName;
            return this;
        }

        /** クエスト名 */
        public string name { set; get; }

        /**
         * クエスト名を設定
         *
         * @param name クエスト名
         * @return this
         */
        public QuestModelMaster WithName(string name) {
            this.name = name;
            return this;
        }

        /** クエストモデルの説明 */
        public string description { set; get; }

        /**
         * クエストモデルの説明を設定
         *
         * @param description クエストモデルの説明
         * @return this
         */
        public QuestModelMaster WithDescription(string description) {
            this.description = description;
            return this;
        }

        /** クエストのメタデータ */
        public string metadata { set; get; }

        /**
         * クエストのメタデータを設定
         *
         * @param metadata クエストのメタデータ
         * @return this
         */
        public QuestModelMaster WithMetadata(string metadata) {
            this.metadata = metadata;
            return this;
        }

        /** クエストの内容 */
        public List<Contents> contents { set; get; }

        /**
         * クエストの内容を設定
         *
         * @param contents クエストの内容
         * @return this
         */
        public QuestModelMaster WithContents(List<Contents> contents) {
            this.contents = contents;
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
        public QuestModelMaster WithChallengePeriodEventId(string challengePeriodEventId) {
            this.challengePeriodEventId = challengePeriodEventId;
            return this;
        }

        /** クエストの参加料 */
        public List<ConsumeAction> consumeActions { set; get; }

        /**
         * クエストの参加料を設定
         *
         * @param consumeActions クエストの参加料
         * @return this
         */
        public QuestModelMaster WithConsumeActions(List<ConsumeAction> consumeActions) {
            this.consumeActions = consumeActions;
            return this;
        }

        /** クエスト失敗時の報酬 */
        public List<AcquireAction> failedAcquireActions { set; get; }

        /**
         * クエスト失敗時の報酬を設定
         *
         * @param failedAcquireActions クエスト失敗時の報酬
         * @return this
         */
        public QuestModelMaster WithFailedAcquireActions(List<AcquireAction> failedAcquireActions) {
            this.failedAcquireActions = failedAcquireActions;
            return this;
        }

        /** クエストに挑戦するためにクリアしておく必要のあるクエスト名 */
        public List<string> premiseQuestNames { set; get; }

        /**
         * クエストに挑戦するためにクリアしておく必要のあるクエスト名を設定
         *
         * @param premiseQuestNames クエストに挑戦するためにクリアしておく必要のあるクエスト名
         * @return this
         */
        public QuestModelMaster WithPremiseQuestNames(List<string> premiseQuestNames) {
            this.premiseQuestNames = premiseQuestNames;
            return this;
        }

        /** 作成日時 */
        public long? createdAt { set; get; }

        /**
         * 作成日時を設定
         *
         * @param createdAt 作成日時
         * @return this
         */
        public QuestModelMaster WithCreatedAt(long? createdAt) {
            this.createdAt = createdAt;
            return this;
        }

        /** 最終更新日時 */
        public long? updatedAt { set; get; }

        /**
         * 最終更新日時を設定
         *
         * @param updatedAt 最終更新日時
         * @return this
         */
        public QuestModelMaster WithUpdatedAt(long? updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.questModelId != null)
            {
                writer.WritePropertyName("questModelId");
                writer.Write(this.questModelId);
            }
            if(this.questGroupName != null)
            {
                writer.WritePropertyName("questGroupName");
                writer.Write(this.questGroupName);
            }
            if(this.name != null)
            {
                writer.WritePropertyName("name");
                writer.Write(this.name);
            }
            if(this.description != null)
            {
                writer.WritePropertyName("description");
                writer.Write(this.description);
            }
            if(this.metadata != null)
            {
                writer.WritePropertyName("metadata");
                writer.Write(this.metadata);
            }
            if(this.contents != null)
            {
                writer.WritePropertyName("contents");
                writer.WriteArrayStart();
                foreach(var item in this.contents)
                {
                    item.WriteJson(writer);
                }
                writer.WriteArrayEnd();
            }
            if(this.challengePeriodEventId != null)
            {
                writer.WritePropertyName("challengePeriodEventId");
                writer.Write(this.challengePeriodEventId);
            }
            if(this.consumeActions != null)
            {
                writer.WritePropertyName("consumeActions");
                writer.WriteArrayStart();
                foreach(var item in this.consumeActions)
                {
                    item.WriteJson(writer);
                }
                writer.WriteArrayEnd();
            }
            if(this.failedAcquireActions != null)
            {
                writer.WritePropertyName("failedAcquireActions");
                writer.WriteArrayStart();
                foreach(var item in this.failedAcquireActions)
                {
                    item.WriteJson(writer);
                }
                writer.WriteArrayEnd();
            }
            if(this.premiseQuestNames != null)
            {
                writer.WritePropertyName("premiseQuestNames");
                writer.WriteArrayStart();
                foreach(var item in this.premiseQuestNames)
                {
                    writer.Write(item);
                }
                writer.WriteArrayEnd();
            }
            if(this.createdAt.HasValue)
            {
                writer.WritePropertyName("createdAt");
                writer.Write(this.createdAt.Value);
            }
            if(this.updatedAt.HasValue)
            {
                writer.WritePropertyName("updatedAt");
                writer.Write(this.updatedAt.Value);
            }
            writer.WriteObjectEnd();
        }

        public static QuestModelMaster FromDict(JsonData data)
        {
            return new QuestModelMaster()
                .WithQuestModelId(data.Keys.Contains("questModelId") ? (string) data["questModelId"] : null)
                .WithQuestGroupName(data.Keys.Contains("questGroupName") ? (string) data["questGroupName"] : null)
                .WithName(data.Keys.Contains("name") ? (string) data["name"] : null)
                .WithDescription(data.Keys.Contains("description") ? (string) data["description"] : null)
                .WithMetadata(data.Keys.Contains("metadata") ? (string) data["metadata"] : null)
                .WithContents(data.Keys.Contains("contents") ? data["contents"].Cast<JsonData>().Select(value =>
                    {
                        return Contents.FromDict(value);
                    }
                ).ToList() : null)
                .WithChallengePeriodEventId(data.Keys.Contains("challengePeriodEventId") ? (string) data["challengePeriodEventId"] : null)
                .WithConsumeActions(data.Keys.Contains("consumeActions") ? data["consumeActions"].Cast<JsonData>().Select(value =>
                    {
                        return ConsumeAction.FromDict(value);
                    }
                ).ToList() : null)
                .WithFailedAcquireActions(data.Keys.Contains("failedAcquireActions") ? data["failedAcquireActions"].Cast<JsonData>().Select(value =>
                    {
                        return AcquireAction.FromDict(value);
                    }
                ).ToList() : null)
                .WithPremiseQuestNames(data.Keys.Contains("premiseQuestNames") ? data["premiseQuestNames"].Cast<JsonData>().Select(value =>
                    {
                        return (string) value;
                    }
                ).ToList() : null)
                .WithCreatedAt(data.Keys.Contains("createdAt") ? (long?) data["createdAt"] : null)
                .WithUpdatedAt(data.Keys.Contains("updatedAt") ? (long?) data["updatedAt"] : null);
        }
	}
}