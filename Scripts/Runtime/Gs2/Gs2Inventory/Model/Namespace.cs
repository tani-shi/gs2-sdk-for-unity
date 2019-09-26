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
using Gs2.Core.Model;
using LitJson;

namespace Gs2.Gs2Inventory.Model
{
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

        /** カテゴリー名 */
        public string name { set; get; }

        /**
         * カテゴリー名を設定
         *
         * @param name カテゴリー名
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

        /** アイテム入手したときに実行するスクリプト */
        public ScriptSetting acquireScript { set; get; }

        /**
         * アイテム入手したときに実行するスクリプトを設定
         *
         * @param acquireScript アイテム入手したときに実行するスクリプト
         * @return this
         */
        public Namespace WithAcquireScript(ScriptSetting acquireScript) {
            this.acquireScript = acquireScript;
            return this;
        }

        /** 入手上限に当たって入手できなかったときに実行するスクリプト */
        public ScriptSetting overflowScript { set; get; }

        /**
         * 入手上限に当たって入手できなかったときに実行するスクリプトを設定
         *
         * @param overflowScript 入手上限に当たって入手できなかったときに実行するスクリプト
         * @return this
         */
        public Namespace WithOverflowScript(ScriptSetting overflowScript) {
            this.overflowScript = overflowScript;
            return this;
        }

        /** アイテム消費するときに実行するスクリプト */
        public ScriptSetting consumeScript { set; get; }

        /**
         * アイテム消費するときに実行するスクリプトを設定
         *
         * @param consumeScript アイテム消費するときに実行するスクリプト
         * @return this
         */
        public Namespace WithConsumeScript(ScriptSetting consumeScript) {
            this.consumeScript = consumeScript;
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
            if(this.acquireScript != null)
            {
                writer.WritePropertyName("acquireScript");
                this.acquireScript.WriteJson(writer);
            }
            if(this.overflowScript != null)
            {
                writer.WritePropertyName("overflowScript");
                this.overflowScript.WriteJson(writer);
            }
            if(this.consumeScript != null)
            {
                writer.WritePropertyName("consumeScript");
                this.consumeScript.WriteJson(writer);
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
	}
}