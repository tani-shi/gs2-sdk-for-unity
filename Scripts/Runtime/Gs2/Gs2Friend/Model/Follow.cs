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

namespace Gs2.Gs2Friend.Model
{
	[Preserve]
	public class Follow
	{

        /** フォロー */
        public string followId { set; get; }

        /**
         * フォローを設定
         *
         * @param followId フォロー
         * @return this
         */
        public Follow WithFollowId(string followId) {
            this.followId = followId;
            return this;
        }

        /** ユーザーID */
        public string userId { set; get; }

        /**
         * ユーザーIDを設定
         *
         * @param userId ユーザーID
         * @return this
         */
        public Follow WithUserId(string userId) {
            this.userId = userId;
            return this;
        }

        /** フォローしているユーザーIDリスト */
        public List<string> targetUserIds { set; get; }

        /**
         * フォローしているユーザーIDリストを設定
         *
         * @param targetUserIds フォローしているユーザーIDリスト
         * @return this
         */
        public Follow WithTargetUserIds(List<string> targetUserIds) {
            this.targetUserIds = targetUserIds;
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
        public Follow WithCreatedAt(long? createdAt) {
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
        public Follow WithUpdatedAt(long? updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.followId != null)
            {
                writer.WritePropertyName("followId");
                writer.Write(this.followId);
            }
            if(this.userId != null)
            {
                writer.WritePropertyName("userId");
                writer.Write(this.userId);
            }
            if(this.targetUserIds != null)
            {
                writer.WritePropertyName("targetUserIds");
                writer.WriteArrayStart();
                foreach(var item in this.targetUserIds)
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

    	[Preserve]
        public static Follow FromDict(JsonData data)
        {
            return new Follow()
                .WithFollowId(data.Keys.Contains("followId") && data["followId"] != null ? data["followId"].ToString() : null)
                .WithUserId(data.Keys.Contains("userId") && data["userId"] != null ? data["userId"].ToString() : null)
                .WithTargetUserIds(data.Keys.Contains("targetUserIds") && data["targetUserIds"] != null ? data["targetUserIds"].Cast<JsonData>().Select(value =>
                    {
                        return value.ToString();
                    }
                ).ToList() : null)
                .WithCreatedAt(data.Keys.Contains("createdAt") && data["createdAt"] != null ? (long?)long.Parse(data["createdAt"].ToString()) : null)
                .WithUpdatedAt(data.Keys.Contains("updatedAt") && data["updatedAt"] != null ? (long?)long.Parse(data["updatedAt"].ToString()) : null);
        }
	}
}