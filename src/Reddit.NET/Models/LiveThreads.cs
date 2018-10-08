﻿using Newtonsoft.Json;
using Reddit.NET.Models.Structures;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.NET.Models
{
    public class LiveThreads : BaseModel
    {
        internal override RestClient RestClient { get; set; }

        public LiveThreads(string appId, string refreshToken, string accessToken, RestClient restClient) : base(appId, refreshToken, accessToken, restClient) { }

        public object GetById(string names)
        {
            return JsonConvert.DeserializeObject(ExecuteRequest("api/live/by_id/" + names));
        }

        public object Create(string description, bool nsfw, string resources, string title)
        {
            RestRequest restRequest = PrepareRequest("api/live/create", Method.POST);

            restRequest.AddParameter("description", description);
            restRequest.AddParameter("nsfw", nsfw);
            restRequest.AddParameter("resources", resources);
            restRequest.AddParameter("title", title);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object HappeningNow()
        {
            return JsonConvert.DeserializeObject(ExecuteRequest("api/live/happening_now"));
        }

        public object AcceptContributorInvite(string thread)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/accept_contributor_invite", Method.POST);

            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object CloseThread(string thread)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/close_thread", Method.POST);

            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object DeleteUpdate(string thread, string id)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/delete_update", Method.POST);

            restRequest.AddParameter("id", id);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object Edit(string thread, string description, bool nsfw, string resources, string title)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/edit", Method.POST);

            restRequest.AddParameter("description", description);
            restRequest.AddParameter("nsfw", nsfw);
            restRequest.AddParameter("resources", resources);
            restRequest.AddParameter("title", title);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object HideDiscussion(string thread, string link)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/hide_discussion", Method.POST);

            restRequest.AddParameter("link", link);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object InviteContributor(string thread, string name, string permissions, string type)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/invite_contributor", Method.POST);

            restRequest.AddParameter("name", name);
            restRequest.AddParameter("permissions", permissions);
            restRequest.AddParameter("type", type);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object LeaveContributor(string thread)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/leave_contributor", Method.POST);

            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object Report(string thread, string type)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/report", Method.POST);

            restRequest.AddParameter("type", type);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object RemoveContributor(string thread, string id)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/rm_contributor", Method.POST);

            restRequest.AddParameter("id", id);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object RemoveContributorInvite(string thread, string id)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/rm_contributor_invite", Method.POST);

            restRequest.AddParameter("id", id);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object SetContributorPermissions(string thread, string name, string permissions, string type)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/set_contributor_permissions", Method.POST);

            restRequest.AddParameter("name", name);
            restRequest.AddParameter("permissions", permissions);
            restRequest.AddParameter("type", type);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object StrikeUpdate(string thread, string id)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/strike_update", Method.POST);

            restRequest.AddParameter("id", id);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object UnhideDiscussion(string thread, string link)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/unhide_discussion", Method.POST);

            restRequest.AddParameter("link", link);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object Update(string thread, string body)
        {
            RestRequest restRequest = PrepareRequest("api/live/" + thread + "/update", Method.POST);

            restRequest.AddParameter("body", body);
            restRequest.AddParameter("api_type", "json");

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object GetUpdates(string thread, string after, string before, string styleSr, int count = 0, int limit = 25)
        {
            RestRequest restRequest = PrepareRequest("live/" + thread);

            restRequest.AddParameter("after", after);
            restRequest.AddParameter("before", before);
            restRequest.AddParameter("stylesr", styleSr);
            restRequest.AddParameter("count", count);
            restRequest.AddParameter("limit", limit);

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object About(string thread)
        {
            return JsonConvert.DeserializeObject(ExecuteRequest("live/" + thread + "/about"));
        }

        public object Contributors(string thread)
        {
            return JsonConvert.DeserializeObject(ExecuteRequest("live/" + thread + "/contributors"));
        }

        public object Discussions(string thread, string after, string before, int count = 0, int limit = 25, string show = "all", bool srDetail = false)
        {
            RestRequest restRequest = PrepareRequest("live/" + thread + "/discussions");

            restRequest.AddParameter("after", after);
            restRequest.AddParameter("before", before);
            restRequest.AddParameter("count", count);
            restRequest.AddParameter("limit", limit);
            restRequest.AddParameter("show", show);
            restRequest.AddParameter("sr_detail", srDetail);

            return JsonConvert.DeserializeObject(ExecuteRequest(restRequest));
        }

        public object GetUpdate(string thread, string updateId)
        {
            return JsonConvert.DeserializeObject(ExecuteRequest("live/" + thread + "/updates/" + updateId));
        }
    }
}