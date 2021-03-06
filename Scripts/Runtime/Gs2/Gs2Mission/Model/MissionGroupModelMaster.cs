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
	public class MissionGroupModelMaster
	{

        /** ミッショングループマスター */
        public string missionGroupId { set; get; }

        /**
         * ミッショングループマスターを設定
         *
         * @param missionGroupId ミッショングループマスター
         * @return this
         */
        public MissionGroupModelMaster WithMissionGroupId(string missionGroupId) {
            this.missionGroupId = missionGroupId;
            return this;
        }

        /** ミッショングループ名 */
        public string name { set; get; }

        /**
         * ミッショングループ名を設定
         *
         * @param name ミッショングループ名
         * @return this
         */
        public MissionGroupModelMaster WithName(string name) {
            this.name = name;
            return this;
        }

        /** メタデータ */
        public string metadata { set; get; }

        /**
         * メタデータを設定
         *
         * @param metadata メタデータ
         * @return this
         */
        public MissionGroupModelMaster WithMetadata(string metadata) {
            this.metadata = metadata;
            return this;
        }

        /** ミッショングループの説明 */
        public string description { set; get; }

        /**
         * ミッショングループの説明を設定
         *
         * @param description ミッショングループの説明
         * @return this
         */
        public MissionGroupModelMaster WithDescription(string description) {
            this.description = description;
            return this;
        }

        /** リセットタイミング */
        public string resetType { set; get; }

        /**
         * リセットタイミングを設定
         *
         * @param resetType リセットタイミング
         * @return this
         */
        public MissionGroupModelMaster WithResetType(string resetType) {
            this.resetType = resetType;
            return this;
        }

        /** リセットをする日にち */
        public int? resetDayOfMonth { set; get; }

        /**
         * リセットをする日にちを設定
         *
         * @param resetDayOfMonth リセットをする日にち
         * @return this
         */
        public MissionGroupModelMaster WithResetDayOfMonth(int? resetDayOfMonth) {
            this.resetDayOfMonth = resetDayOfMonth;
            return this;
        }

        /** リセットする曜日 */
        public string resetDayOfWeek { set; get; }

        /**
         * リセットする曜日を設定
         *
         * @param resetDayOfWeek リセットする曜日
         * @return this
         */
        public MissionGroupModelMaster WithResetDayOfWeek(string resetDayOfWeek) {
            this.resetDayOfWeek = resetDayOfWeek;
            return this;
        }

        /** リセット時刻 */
        public int? resetHour { set; get; }

        /**
         * リセット時刻を設定
         *
         * @param resetHour リセット時刻
         * @return this
         */
        public MissionGroupModelMaster WithResetHour(int? resetHour) {
            this.resetHour = resetHour;
            return this;
        }

        /** ミッションを達成したときの通知先ネームスペース のGRN */
        public string completeNotificationNamespaceId { set; get; }

        /**
         * ミッションを達成したときの通知先ネームスペース のGRNを設定
         *
         * @param completeNotificationNamespaceId ミッションを達成したときの通知先ネームスペース のGRN
         * @return this
         */
        public MissionGroupModelMaster WithCompleteNotificationNamespaceId(string completeNotificationNamespaceId) {
            this.completeNotificationNamespaceId = completeNotificationNamespaceId;
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
        public MissionGroupModelMaster WithCreatedAt(long? createdAt) {
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
        public MissionGroupModelMaster WithUpdatedAt(long? updatedAt) {
            this.updatedAt = updatedAt;
            return this;
        }

        public void WriteJson(JsonWriter writer)
        {
            writer.WriteObjectStart();
            if(this.missionGroupId != null)
            {
                writer.WritePropertyName("missionGroupId");
                writer.Write(this.missionGroupId);
            }
            if(this.name != null)
            {
                writer.WritePropertyName("name");
                writer.Write(this.name);
            }
            if(this.metadata != null)
            {
                writer.WritePropertyName("metadata");
                writer.Write(this.metadata);
            }
            if(this.description != null)
            {
                writer.WritePropertyName("description");
                writer.Write(this.description);
            }
            if(this.resetType != null)
            {
                writer.WritePropertyName("resetType");
                writer.Write(this.resetType);
            }
            if(this.resetDayOfMonth.HasValue)
            {
                writer.WritePropertyName("resetDayOfMonth");
                writer.Write(this.resetDayOfMonth.Value);
            }
            if(this.resetDayOfWeek != null)
            {
                writer.WritePropertyName("resetDayOfWeek");
                writer.Write(this.resetDayOfWeek);
            }
            if(this.resetHour.HasValue)
            {
                writer.WritePropertyName("resetHour");
                writer.Write(this.resetHour.Value);
            }
            if(this.completeNotificationNamespaceId != null)
            {
                writer.WritePropertyName("completeNotificationNamespaceId");
                writer.Write(this.completeNotificationNamespaceId);
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
        public static MissionGroupModelMaster FromDict(JsonData data)
        {
            return new MissionGroupModelMaster()
                .WithMissionGroupId(data.Keys.Contains("missionGroupId") && data["missionGroupId"] != null ? data["missionGroupId"].ToString() : null)
                .WithName(data.Keys.Contains("name") && data["name"] != null ? data["name"].ToString() : null)
                .WithMetadata(data.Keys.Contains("metadata") && data["metadata"] != null ? data["metadata"].ToString() : null)
                .WithDescription(data.Keys.Contains("description") && data["description"] != null ? data["description"].ToString() : null)
                .WithResetType(data.Keys.Contains("resetType") && data["resetType"] != null ? data["resetType"].ToString() : null)
                .WithResetDayOfMonth(data.Keys.Contains("resetDayOfMonth") && data["resetDayOfMonth"] != null ? (int?)int.Parse(data["resetDayOfMonth"].ToString()) : null)
                .WithResetDayOfWeek(data.Keys.Contains("resetDayOfWeek") && data["resetDayOfWeek"] != null ? data["resetDayOfWeek"].ToString() : null)
                .WithResetHour(data.Keys.Contains("resetHour") && data["resetHour"] != null ? (int?)int.Parse(data["resetHour"].ToString()) : null)
                .WithCompleteNotificationNamespaceId(data.Keys.Contains("completeNotificationNamespaceId") && data["completeNotificationNamespaceId"] != null ? data["completeNotificationNamespaceId"].ToString() : null)
                .WithCreatedAt(data.Keys.Contains("createdAt") && data["createdAt"] != null ? (long?)long.Parse(data["createdAt"].ToString()) : null)
                .WithUpdatedAt(data.Keys.Contains("updatedAt") && data["updatedAt"] != null ? (long?)long.Parse(data["updatedAt"].ToString()) : null);
        }
	}
}