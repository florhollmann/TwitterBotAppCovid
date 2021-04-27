using LINQtoCSV;
using System;

namespace TwitterBotAppCovid.DataHandler
{
    public class OwidCovidData
    {
        #nullable enable
        [CsvColumn(FieldIndex = 1)]
        public string? iso_code { get; set; }
        [CsvColumn(FieldIndex = 2)]
        public string? continent { get; set; }
        [CsvColumn(FieldIndex = 3)]
        public string? location { get; set; }
        [CsvColumn(FieldIndex = 4)]
        public DateTime date { get; set; }
        [CsvColumn(FieldIndex = 5)]
        public string? total_cases { get; set; }
        [CsvColumn(FieldIndex = 6)]
        public string? new_cases { get; set; }
        [CsvColumn(FieldIndex = 7)]
        public string? new_cases_smoothed { get; set; }
        [CsvColumn(FieldIndex = 8)]
        public string? total_deaths { get; set; }
        [CsvColumn(FieldIndex = 9)]
        public string? new_deaths { get; set; }
        [CsvColumn(FieldIndex = 10)]
        public string? new_deaths_smoothed { get; set; }
        [CsvColumn(FieldIndex = 11)]
        public string? total_cases_per_million { get; set; }
        [CsvColumn(FieldIndex = 12)]
        public string? new_cases_per_million { get; set; }
        public string? new_cases_smoothed_per_million { get; set; }
        [CsvColumn(FieldIndex = 13)]
        public string? total_deaths_per_million { get; set; }
        [CsvColumn(FieldIndex = 14)]
        public string? new_deaths_per_million { get; set; }
        [CsvColumn(FieldIndex = 15)]
        public string? new_deaths_smoothed_per_million { get; set; }
        [CsvColumn(FieldIndex = 16)]
        public string? reproduction_rate { get; set; }
        [CsvColumn(FieldIndex = 17)]
        public string? icu_patients { get; set; }
        [CsvColumn(FieldIndex = 18)]
        public string? icu_patients_per_million { get; set; }
        [CsvColumn(FieldIndex = 19)]
        public string? hosp_patients { get; set; }
        [CsvColumn(FieldIndex = 20)]
        public string? hosp_patients_per_million { get; set; }
        [CsvColumn(FieldIndex = 21)]
        public string? weekly_icu_admissions { get; set; }
        [CsvColumn(FieldIndex = 22)]
        public string? weekly_icu_admissions_per_million { get; set; }

        [CsvColumn(FieldIndex = 23)]
        public string? weekly_hosp_admissions { get; set; }
        [CsvColumn(FieldIndex = 24)]
        public string? weekly_hosp_admissions_per_million { get; set; }
        [CsvColumn(FieldIndex = 25)]
        public string? new_tests { get; set; }
        [CsvColumn(FieldIndex = 26)]
        public string? total_tests { get; set; }
        [CsvColumn(FieldIndex = 27)]
        public string? total_tests_per_thousand { get; set; }
        [CsvColumn(FieldIndex = 28)]
        public string? new_tests_per_thousand { get; set; }
        [CsvColumn(FieldIndex = 29)]
        public string? new_tests_smoothed { get; set; }
        [CsvColumn(FieldIndex = 30)]
        public string? new_tests_smoothed_per_thousand { get; set; }
        [CsvColumn(FieldIndex = 31)]
        public string? positive_rate { get; set; }
        [CsvColumn(FieldIndex = 32)]
        public string? tests_per_case { get; set; }
        [CsvColumn(FieldIndex = 33)]
        public string? tests_units { get; set; }
        public string? total_vaccinations { get; set; }
        [CsvColumn(FieldIndex = 34)]
        public string? people_vaccinated { get; set; }
        [CsvColumn(FieldIndex = 35)]
        public string? people_fully_vaccinated { get; set; }
        [CsvColumn(FieldIndex = 36)]
        public string? new_vaccinations { get; set; }
        [CsvColumn(FieldIndex = 37)]
        public string? new_vaccinations_smoothed { get; set; }
        [CsvColumn(FieldIndex = 38)]
        public string? total_vaccinations_per_hundred { get; set; }
        [CsvColumn(FieldIndex = 39)]
        public string? people_vaccinated_per_hundred { get; set; }
        [CsvColumn(FieldIndex = 40)]
        public string? people_fully_vaccinated_per_hundred { get; set; }
        [CsvColumn(FieldIndex = 41)]
        public string? new_vaccinations_smoothed_per_million { get; set; }
        [CsvColumn(FieldIndex = 42)]
        public string? stringency_index { get; set; }
        [CsvColumn(FieldIndex = 43)]
        public string? population { get; set; }
        [CsvColumn(FieldIndex = 44)]
        public string? population_density { get; set; }
        [CsvColumn(FieldIndex = 45)]
        public string? median_age { get; set; }
        [CsvColumn(FieldIndex = 46)]
        public string? aged_65_older { get; set; }
        [CsvColumn(FieldIndex = 47)]
        public string? aged_70_older { get; set; }
        [CsvColumn(FieldIndex = 48)]
        public string? gdp_per_capita { get; set; }
        [CsvColumn(FieldIndex = 49)]
        public string? extreme_poverty { get; set; }
        [CsvColumn(FieldIndex = 50)]
        public string? cardiovasc_death_rate { get; set; }
        [CsvColumn(FieldIndex = 51)]
        public string? diabetes_prevalence { get; set; }
        [CsvColumn(FieldIndex = 52)]
        public string? female_smokers { get; set; }
        [CsvColumn(FieldIndex = 53)]
        public string? male_smokers { get; set; }
        [CsvColumn(FieldIndex = 54)]
        public string? handwashing_facilities { get; set; }
        [CsvColumn(FieldIndex = 55)]
        public string? hospital_beds_per_thousand { get; set; }
        [CsvColumn(FieldIndex = 56)]
        public string? life_expectancy { get; set; }
        [CsvColumn(FieldIndex = 57)]
        public string? human_development_index { get; set; }
    }
}
