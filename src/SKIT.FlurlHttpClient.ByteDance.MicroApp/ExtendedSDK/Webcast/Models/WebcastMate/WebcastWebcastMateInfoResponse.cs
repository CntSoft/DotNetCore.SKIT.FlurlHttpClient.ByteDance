namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.ExtendedSDK.Webcast.Models
{
    /// <summary>
    /// <para>表示 [POST] /webcastmate/info 接口的响应。</para>
    /// </summary>
    public class WebcastWebcastMateInfoResponse : DouyinMicroAppWebcastResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class LiveInfo
                    {
                        /// <summary>
                        /// 获取或设置直播间 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("room_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("room_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string RoomId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主播的 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("anchor_open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("anchor_open_id")]
                        public string AnchorOpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主播的昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nick_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
                        public string AnchorNickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置主播的头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("avatar_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
                        public string AnchorAvatarUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置支持的游戏场景列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("available_game_scenes")]
                        [System.Text.Json.Serialization.JsonPropertyName("available_game_scenes")]
                        public int[]? AvailableGameSceneList { get; set; }

                        /// <summary>
                        /// 获取或设置当前加入游戏的用户 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("join_game_user_open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("join_game_user_open_id")]
                        public string? JoinedGameUserOpenId { get; set; }

                        /// <summary>
                        /// 获取或设置当前加入游戏的用户角色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("join_game_user_role")]
                        [System.Text.Json.Serialization.JsonPropertyName("join_game_user_role")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? JoinedGameUserRole { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置直播信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("info")]
                [System.Text.Json.Serialization.JsonPropertyName("info")]
                public Types.LiveInfo LiveInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
