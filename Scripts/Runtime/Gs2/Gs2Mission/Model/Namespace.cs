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

namespace Gs2.Gs2Mission.Model
{
	[Preserve]
	public class Namespace
	{

        /** ネームスペース */
        public string namespaceId { set; get; }

        /**
         * ネームスペースを設定
         *
         * @param namespaceId ネームスペース
         * @return this
         */
        public Namespace WithNamespaceId(string namespaceId) {
            this.namespaceId = namespaceId;
            return this;
        }

        /** オーナーID */
        public string ownerId { set; get; }

        /**
         * オーナーIDを設定
         *
         * @param ownerId オーナーID
         * @return this
         */
        public Namespace WithOwnerId(string ownerId) {
            this.ownerId = ownerId;
            return this;
        }

        /** ネームスペース名 */
        public string name { set; get; }

        /**
         * ネームスペース名を設定
         *
         * @param name ネームスペース名
         * @return this
         */
        public Namespace WithName(string name) {
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
        public Namespace WithDescription(string description) {
            this.description = description;
            return this;
        }

        /** ミッションを達成したときに実行するスクリプト */
        public Gs2.Gs2Mission.Model.ScriptSetting missionCompleteScript { set; get; }

        /**
         * ミッションを達成したときに実行するスクリプトを設定
         *
         * @param missionCompleteScript ミッションを達成したときに実行するスクリプト
         * @return this
         */
        public Namespace WithMissionCompleteScript(Gs2.Gs2Mission.Model.ScriptSetting missionCompleteScript) {
            this.missionCompleteScript = missionCompleteScript;
            return this;
        }

        /** カウンターを上昇したときに実行するスクリプト */
        public Gs2.Gs2Mission.Model.ScriptSetting counterIncrementScript { set; get; }

        /**
         * カウンターを上昇したときに実行するスクリプトを設定
         *
         * @param counterIncrementScript カウンターを上昇したときに実行するスクリプト
         * @return this
         */
        public Namespace WithCounterIncrementScript(Gs2.Gs2Mission.Model.ScriptSetting counterIncrementScript) {
            this.counterIncrementScript = counterIncrementScript;
            return this;
        }

        /** 報酬を受け取ったときに実行するスクリプト */
        public Gs2.Gs2Mission.Model.ScriptSetting receiveRewardsScript { set; get; }

        /**
         * 報酬を受け取ったときに実行するスクリプトを設定
         *
         * @param receiveRewardsScript 報酬を受け取ったときに実行するスクリプト
         * @return this
         */
        public Namespace WithReceiveRewardsScript(Gs2.Gs2Mission.Model.ScriptSetting receiveRewardsScript) {
            this.receiveRewardsScript = receiveRewardsScript;
            return this;
        }

        /** 報酬付与処理をジョブとして追加するキューネームスペース のGRN */
        public string queueNamespaceId { set; get; }

        /**
         * 報酬付与処理をジョブとして追加するキューネームスペース のGRNを設定
         *
         * @param queueNamespaceId 報酬付与処理をジョブとして追加するキューネームスペース のGRN
         * @return this
         */
        public Namespace WithQueueNamespaceId(string queueNamespaceId) {
            this.queueNamespaceId = queueNamespaceId;
            return this;
        }

        /** 報酬付与処理のスタンプシートで使用する暗号鍵GRN */
        public string keyId { set; get; }

        /**
         * 報酬付与処理のスタンプシートで使用する暗号鍵GRNを設定
         *
         * @param keyId 報酬付与処理のスタンプシートで使用する暗号鍵GRN
         * @return this
         */
        public Namespace WithKeyId(string keyId) {
            this.keyId = keyId;
            return this;
        }

        /** ミッションのタスクを達成したときのプッシュ通知 */
        public Gs2.Gs2Mission.Model.NotificationSetting completeNotification { set; get; }

        /**
         * ミッションのタスクを達成したときのプッシュ通知を設定
         *
         * @param completeNotification ミッションのタスクを達成したときのプッシュ通知
         * @return this
         */
        public Namespace WithCompleteNotification(Gs2.Gs2Mission.Model.NotificationSetting completeNotification) {
            this.completeNotification = completeNotification;
            return this;
        }

        /** ログの出力設定 */
        public Gs2.Gs2Mission.Model.LogSetting logSetting { set; get; }

        /**
         * ログの出力設定を設定
         *
         * @param logSetting ログの出力設定
         * @return this
         */
        public Namespace WithLogSetting(Gs2.Gs2Mission.Model.LogSetting logSetting) {
            this.logSetting = logSetting;
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
        public Namespace WithCreatedAt(long? createdAt) {
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
        public Namespace WithUpdatedAt(long? updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.namespaceId != null)
            {
                writer.WritePropertyName("namespaceId");
                writer.Write(this.namespaceId);
            }
            if(this.ownerId != null)
            {
                writer.WritePropertyName("ownerId");
                writer.Write(this.ownerId);
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
            if(this.missionCompleteScript != null)
            {
                writer.WritePropertyName("missionCompleteScript");
                this.missionCompleteScript.WriteJson(writer);
            }
            if(this.counterIncrementScript != null)
            {
                writer.WritePropertyName("counterIncrementScript");
                this.counterIncrementScript.WriteJson(writer);
            }
            if(this.receiveRewardsScript != null)
            {
                writer.WritePropertyName("receiveRewardsScript");
                this.receiveRewardsScript.WriteJson(writer);
            }
            if(this.queueNamespaceId != null)
            {
                writer.WritePropertyName("queueNamespaceId");
                writer.Write(this.queueNamespaceId);
            }
            if(this.keyId != null)
            {
                writer.WritePropertyName("keyId");
                writer.Write(this.keyId);
            }
            if(this.completeNotification != null)
            {
                writer.WritePropertyName("completeNotification");
                this.completeNotification.WriteJson(writer);
            }
            if(this.logSetting != null)
            {
                writer.WritePropertyName("logSetting");
                this.logSetting.WriteJson(writer);
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

    	[Preserve]
        public static Namespace FromDict(JsonData data)
        {
            return new Namespace()
                .WithNamespaceId(data.Keys.Contains("namespaceId") && data["namespaceId"] != null ? data["namespaceId"].ToString() : null)
                .WithOwnerId(data.Keys.Contains("ownerId") && data["ownerId"] != null ? data["ownerId"].ToString() : null)
                .WithName(data.Keys.Contains("name") && data["name"] != null ? data["name"].ToString() : null)
                .WithDescription(data.Keys.Contains("description") && data["description"] != null ? data["description"].ToString() : null)
                .WithMissionCompleteScript(data.Keys.Contains("missionCompleteScript") && data["missionCompleteScript"] != null ? Gs2.Gs2Mission.Model.ScriptSetting.FromDict(data["missionCompleteScript"]) : null)
                .WithCounterIncrementScript(data.Keys.Contains("counterIncrementScript") && data["counterIncrementScript"] != null ? Gs2.Gs2Mission.Model.ScriptSetting.FromDict(data["counterIncrementScript"]) : null)
                .WithReceiveRewardsScript(data.Keys.Contains("receiveRewardsScript") && data["receiveRewardsScript"] != null ? Gs2.Gs2Mission.Model.ScriptSetting.FromDict(data["receiveRewardsScript"]) : null)
                .WithQueueNamespaceId(data.Keys.Contains("queueNamespaceId") && data["queueNamespaceId"] != null ? data["queueNamespaceId"].ToString() : null)
                .WithKeyId(data.Keys.Contains("keyId") && data["keyId"] != null ? data["keyId"].ToString() : null)
                .WithCompleteNotification(data.Keys.Contains("completeNotification") && data["completeNotification"] != null ? Gs2.Gs2Mission.Model.NotificationSetting.FromDict(data["completeNotification"]) : null)
                .WithLogSetting(data.Keys.Contains("logSetting") && data["logSetting"] != null ? Gs2.Gs2Mission.Model.LogSetting.FromDict(data["logSetting"]) : null)
                .WithCreatedAt(data.Keys.Contains("createdAt") && data["createdAt"] != null ? (long?)long.Parse(data["createdAt"].ToString()) : null)
                .WithUpdatedAt(data.Keys.Contains("updatedAt") && data["updatedAt"] != null ? (long?)long.Parse(data["updatedAt"].ToString()) : null);
        }
	}
}