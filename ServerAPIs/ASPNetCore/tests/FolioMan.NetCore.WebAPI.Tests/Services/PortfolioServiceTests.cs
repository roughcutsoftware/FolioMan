using System;
using System.Linq;
using System.Reflection;
using Bogus;
using FolioMan.NetCore.WebAPI.Models;
using FolioMan.NetCore.WebAPI.Services;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace FolioMan.NetCore.WebAPI.Tests.Services
{
    public class PortfolioServiceTests
    {
        private Faker fakerSvc; 

        [SetUp]
        public void Setup()
        {
            fakerSvc = new Faker("en");
        }

        [TearDown]
        public void Teardown()
        {
            // pending, if required
        }

        [Test]
        public void Test1()
        {
            // this works!
            string tempHold2 = TestingService.GetStringResourceByName();

            WorkHistoryModel workHistory = new WorkHistoryModel()
            {
                WorkHistoryGuidKeyId = Guid.NewGuid(),
                Employer = GetEmployer(),
                WorkHighlights = new Faker<WorkHighlightModel>()
                    .RuleFor(r => r.Highlight, fakerSvc.Lorem.Sentence())
                    .Generate(4)
                    .ToList()
            };

            PortfolioModel testData = new Faker<PortfolioModel>()
                //.RuleFor(r => r.WorkHistory)
                .Generate();

            PortfolioModel portfolio = new PortfolioModel()
            {
                //
                Candidate = new Faker<CandidateModel>()
                    .RuleFor(r => r.Name, f => fakerSvc.Person.FullName)
                    .RuleFor(r => r.Email, f => fakerSvc.Person.Email)
                    .Generate(),

                //
                WorkHistory = new Faker<WorkHistoryModel>()
                    .RuleFor(r => r.JobTitle, f => "IT Professional")
                    .RuleFor(r => r.Employer, f => GetEmployer())
                    .RuleFor(r => r.WorkHighlights, f => new Faker<WorkHighlightModel>()
                        .RuleFor(r => r.Highlight, fakerSvc.Lorem.Sentence())
                        .Generate(4).ToList())
                    .Generate(4)
            };

            string jsonString = JsonConvert.SerializeObject(portfolio);
            System.IO.File.WriteAllText(@"D:\repos\RoughcutSoftware\PortfolioManager\FolioMan.NetCore.WebAPI.NUnit.Tests\exports\0100-bogus-testdata.json", jsonString);

            string test = Assembly.GetExecutingAssembly().GetName().Name;
            // FolioMan.NetCore.WebAPI.TestingData.0100-bogus-testdata.json

        }

        private EmployerModel GetEmployer()
        {

            var employer = new EmployerModel()
            {
                EmployerGuidKeyId = Guid.NewGuid(),
                Name = fakerSvc.Company.CompanyName(),
                State = fakerSvc.Address.State(),
                City = fakerSvc.Address.City()
            };

            return employer;
        }
    }
}