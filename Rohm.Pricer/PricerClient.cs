﻿using Rohm.Pricer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;

namespace Rohm.Pricer
{
    public class PricerClient
    {

        private readonly ApiClient _apiClient;

        public PricerClient()
        {
            _apiClient = new ApiClient(baseUrl: ConfigurationManager.AppSettings["PricerApiUrl"]);
        }               

        public Job[] GetAllJobs() {
            return _apiClient.Request<Job[]>(Methods.GET, "jobs");
        }

        public Job GetSingleJob(int jobId)
        {
            return _apiClient.Request<Job>(Methods.GET, $"jobs/{jobId}");
        }

        public Job DeleteJob(int jobId)
        {
            return _apiClient.Request<Job>(Methods.DELETE, $"jobs/{jobId}");
        }

        public CreateResult CreateDisableTransceivers(Job job)
        {
            return _apiClient.Request<CreateResult>(Methods.POST, 
                $"jobs/disable-transceivers", job);
        }

        public UpdateResult CreateOrUpdateDisableTransceivers(int jobId, Job job)
        {

            return _apiClient.Request<UpdateResult>(Methods.PUT,
                $"jobs/disable-transceivers/{jobId}", job);
        }

        public UpdateResult UpdateDisableTransceivers(int jobId, Job job)
        {
            return _apiClient.Request<UpdateResult>(Methods.PATCH,
                $"jobs/disable-transceivers/{jobId}", job);

        }

        public CreateResult CreateDisplayPageGraphical(Job job)
        {
            return _apiClient.Request<CreateResult>(Methods.POST,
                 $"jobs/display-page-graphical", job);
        }

        public UpdateResult UpdateOrCreateDisplayPageGraphical(int jobId, Job job)
        {
            return _apiClient.Request<UpdateResult>(Methods.PUT,
                 $"jobs/display-page-graphical/{jobId}", job);
        }

        public UpdateResult UpdateDisplayPageGraphical(int jobId, Job job)
        {
            return _apiClient.Request<UpdateResult>(Methods.PATCH,
                 $"jobs/display-page-graphical/{jobId}", job);
        }

        public CreateResult CreateDisplayPageSegment(Job job)
        {
            return _apiClient.Request<CreateResult>(Methods.POST,
                 $"jobs/display-page-segment", job);

        }

        public UpdateResult UpdateOrCreateDisplayPageSegment(int jobId, Job job)
        {
            return _apiClient.Request<UpdateResult>(Methods.PUT,
                 $"jobs/display-page-segment/{jobId}", job);
        }

        public UpdateResult UpdateDisplayPageSegment(int jobId, Job job)
        {
            return _apiClient.Request<UpdateResult>(Methods.PATCH,
                 $"jobs/display-page-segment/{jobId}", job);
        }

        public CreateResult CreateGenerateReport(Job job)
        {
            return _apiClient.Request<CreateResult>(Methods.POST,
                 $"jobs/generate-report", job);

        }

        public UpdateResult UpdateOrCreateGenerateReport(int jobId, Job job)
        {
            return _apiClient.Request<UpdateResult>(Methods.PUT,
                 $"jobs/generate-report/{jobId}", job);

        }

        public UpdateResult UpdateGenerateReport(int jobId, Job job)
        {
            return _apiClient.Request<UpdateResult>(Methods.PATCH,
                 $"jobs/generate-report/{jobId}", job);

        }

        public DisplayPageResponse DisplayPage(DisplayPageRequest request)
        { 
            return _apiClient.Request<DisplayPageResponse>(Methods.POST,
                 $"api/public/core/v1/display-page/labels", request);
        }

    }
}
