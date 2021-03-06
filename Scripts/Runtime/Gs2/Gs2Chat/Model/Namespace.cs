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

namespace Gs2.Gs2Chat.Model
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

        /** ゲームプレイヤーによるルームの作成を許可するか */
        public bool? allowCreateRoom { set; get; }

        /**
         * ゲームプレイヤーによるルームの作成を許可するかを設定
         *
         * @param allowCreateRoom ゲームプレイヤーによるルームの作成を許可するか
         * @return this
         */
        public Namespace WithAllowCreateRoom(bool? allowCreateRoom) {
            this.allowCreateRoom = allowCreateRoom;
            return this;
        }

        /** メッセージを投稿したときに実行するスクリプト */
        public Gs2.Gs2Chat.Model.ScriptSetting postMessageScript { set; get; }

        /**
         * メッセージを投稿したときに実行するスクリプトを設定
         *
         * @param postMessageScript メッセージを投稿したときに実行するスクリプト
         * @return this
         */
        public Namespace WithPostMessageScript(Gs2.Gs2Chat.Model.ScriptSetting postMessageScript) {
            this.postMessageScript = postMessageScript;
            return this;
        }

        /** ルームを作成したときに実行するスクリプト */
        public Gs2.Gs2Chat.Model.ScriptSetting createRoomScript { set; get; }

        /**
         * ルームを作成したときに実行するスクリプトを設定
         *
         * @param createRoomScript ルームを作成したときに実行するスクリプト
         * @return this
         */
        public Namespace WithCreateRoomScript(Gs2.Gs2Chat.Model.ScriptSetting createRoomScript) {
            this.createRoomScript = createRoomScript;
            return this;
        }

        /** ルームを削除したときに実行するスクリプト */
        public Gs2.Gs2Chat.Model.ScriptSetting deleteRoomScript { set; get; }

        /**
         * ルームを削除したときに実行するスクリプトを設定
         *
         * @param deleteRoomScript ルームを削除したときに実行するスクリプト
         * @return this
         */
        public Namespace WithDeleteRoomScript(Gs2.Gs2Chat.Model.ScriptSetting deleteRoomScript) {
            this.deleteRoomScript = deleteRoomScript;
            return this;
        }

        /** ルームを購読したときに実行するスクリプト */
        public Gs2.Gs2Chat.Model.ScriptSetting subscribeRoomScript { set; get; }

        /**
         * ルームを購読したときに実行するスクリプトを設定
         *
         * @param subscribeRoomScript ルームを購読したときに実行するスクリプト
         * @return this
         */
        public Namespace WithSubscribeRoomScript(Gs2.Gs2Chat.Model.ScriptSetting subscribeRoomScript) {
            this.subscribeRoomScript = subscribeRoomScript;
            return this;
        }

        /** ルームの購読を解除したときに実行するスクリプト */
        public Gs2.Gs2Chat.Model.ScriptSetting unsubscribeRoomScript { set; get; }

        /**
         * ルームの購読を解除したときに実行するスクリプトを設定
         *
         * @param unsubscribeRoomScript ルームの購読を解除したときに実行するスクリプト
         * @return this
         */
        public Namespace WithUnsubscribeRoomScript(Gs2.Gs2Chat.Model.ScriptSetting unsubscribeRoomScript) {
            this.unsubscribeRoomScript = unsubscribeRoomScript;
            return this;
        }

        /** 購読しているルームに新しい投稿がきたときのプッシュ通知 */
        public Gs2.Gs2Chat.Model.NotificationSetting postNotification { set; get; }

        /**
         * 購読しているルームに新しい投稿がきたときのプッシュ通知を設定
         *
         * @param postNotification 購読しているルームに新しい投稿がきたときのプッシュ通知
         * @return this
         */
        public Namespace WithPostNotification(Gs2.Gs2Chat.Model.NotificationSetting postNotification) {
            this.postNotification = postNotification;
            return this;
        }

        /** ログの出力設定 */
        public Gs2.Gs2Chat.Model.LogSetting logSetting { set; get; }

        /**
         * ログの出力設定を設定
         *
         * @param logSetting ログの出力設定
         * @return this
         */
        public Namespace WithLogSetting(Gs2.Gs2Chat.Model.LogSetting logSetting) {
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
            if(this.allowCreateRoom.HasValue)
            {
                writer.WritePropertyName("allowCreateRoom");
                writer.Write(this.allowCreateRoom.Value);
            }
            if(this.postMessageScript != null)
            {
                writer.WritePropertyName("postMessageScript");
                this.postMessageScript.WriteJson(writer);
            }
            if(this.createRoomScript != null)
            {
                writer.WritePropertyName("createRoomScript");
                this.createRoomScript.WriteJson(writer);
            }
            if(this.deleteRoomScript != null)
            {
                writer.WritePropertyName("deleteRoomScript");
                this.deleteRoomScript.WriteJson(writer);
            }
            if(this.subscribeRoomScript != null)
            {
                writer.WritePropertyName("subscribeRoomScript");
                this.subscribeRoomScript.WriteJson(writer);
            }
            if(this.unsubscribeRoomScript != null)
            {
                writer.WritePropertyName("unsubscribeRoomScript");
                this.unsubscribeRoomScript.WriteJson(writer);
            }
            if(this.postNotification != null)
            {
                writer.WritePropertyName("postNotification");
                this.postNotification.WriteJson(writer);
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
                .WithAllowCreateRoom(data.Keys.Contains("allowCreateRoom") && data["allowCreateRoom"] != null ? (bool?)bool.Parse(data["allowCreateRoom"].ToString()) : null)
                .WithPostMessageScript(data.Keys.Contains("postMessageScript") && data["postMessageScript"] != null ? Gs2.Gs2Chat.Model.ScriptSetting.FromDict(data["postMessageScript"]) : null)
                .WithCreateRoomScript(data.Keys.Contains("createRoomScript") && data["createRoomScript"] != null ? Gs2.Gs2Chat.Model.ScriptSetting.FromDict(data["createRoomScript"]) : null)
                .WithDeleteRoomScript(data.Keys.Contains("deleteRoomScript") && data["deleteRoomScript"] != null ? Gs2.Gs2Chat.Model.ScriptSetting.FromDict(data["deleteRoomScript"]) : null)
                .WithSubscribeRoomScript(data.Keys.Contains("subscribeRoomScript") && data["subscribeRoomScript"] != null ? Gs2.Gs2Chat.Model.ScriptSetting.FromDict(data["subscribeRoomScript"]) : null)
                .WithUnsubscribeRoomScript(data.Keys.Contains("unsubscribeRoomScript") && data["unsubscribeRoomScript"] != null ? Gs2.Gs2Chat.Model.ScriptSetting.FromDict(data["unsubscribeRoomScript"]) : null)
                .WithPostNotification(data.Keys.Contains("postNotification") && data["postNotification"] != null ? Gs2.Gs2Chat.Model.NotificationSetting.FromDict(data["postNotification"]) : null)
                .WithLogSetting(data.Keys.Contains("logSetting") && data["logSetting"] != null ? Gs2.Gs2Chat.Model.LogSetting.FromDict(data["logSetting"]) : null)
                .WithCreatedAt(data.Keys.Contains("createdAt") && data["createdAt"] != null ? (long?)long.Parse(data["createdAt"].ToString()) : null)
                .WithUpdatedAt(data.Keys.Contains("updatedAt") && data["updatedAt"] != null ? (long?)long.Parse(data["updatedAt"].ToString()) : null);
        }
	}
}