using Newtonsoft.Json;
using NYCSubwayStations.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NYCSubwayStations.Database.Database.Configurations
{
    public class SubwayStationsList
    {
        public SubwayStationsList()
        {
            subwayStations = GetSubwayStationsFromJson();
        }
        private List<SubwayStation> _subwayStations;
        public List<SubwayStation> subwayStations 
        { 
            get { return _subwayStations; } 
            set
            {
                if (value == null)
                {
                    _subwayStations = GetSubwayStationsFromJson();
                }
            }
        }


        public List<SubwayStation> GetSubwayStationsFromJson()
        {
            #region JSON

            string json = @"
[
    {
      ""ID"": 1,
      ""NAME"": ""Astor Pl"",
      ""Longitude"": ""-73.99106999861966"",
      ""Latitude"": ""40.73005400028978"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 2,
      ""NAME"": ""Canal St"",
      ""Longitude"": ""-74.00019299927328"",
      ""Latitude"": ""40.71880300107709"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 3,
      ""NAME"": ""50th St"",
      ""Longitude"": ""-73.98384899986625"",
      ""Latitude"": ""40.76172799961419"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 4,
      ""NAME"": ""Bergen St"",
      ""Longitude"": ""-73.97499915116808"",
      ""Latitude"": ""40.68086213682956"",
      ""LINE"": ""2-3-4"",
      ""NOTES"": ""4-nights, 3-all other times, 2-all times"" 
    },
    {
      ""ID"": 5,
      ""NAME"": ""Pennsylvania Ave"",
      ""Longitude"": ""-73.89488591154061"",
      ""Latitude"": ""40.66471445143568"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 6,
      ""NAME"": ""238th St"",
      ""Longitude"": ""-73.90087000018522"",
      ""Latitude"": ""40.88466700064975"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times, exit only northbound"" 
    },
    {
      ""ID"": 7,
      ""NAME"": ""Cathedral Pkwy,110th St"",
      ""Longitude"": ""-73.95806670661364"",
      ""Latitude"": ""40.800581558114956"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights""
    },
    {
      ""ID"": 8,
      ""NAME"": ""Kingston - Throop Aves"",
      ""Longitude"": ""-73.94085899871263"",
      ""Latitude"": ""40.67991899941601"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 9,
      ""NAME"": ""65th St"",
      ""Longitude"": ""-73.8987883783301"",
      ""Latitude"": ""40.74971952935675"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 10,
      ""NAME"": ""36th St"",
      ""Longitude"": ""-73.92901818461539"",
      ""Latitude"": ""40.75196004401078"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 11,
      ""NAME"": ""Delancey St - Essex St"",
      ""Longitude"": ""-73.98740940202974"",
      ""Latitude"": ""40.71830605618619"",
      ""LINE"": ""J-M-Z"",
      ""NOTES"": ""J-all times, M-all times exc nights, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 12,
      ""NAME"": ""Van Siclen Ave"",
      ""Longitude"": ""-73.89165772702445"",
      ""Latitude"": ""40.67802821447783"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""Z-rush hours AM westbound, PM eastbound, J-all other times"" 
    },
    {
      ""ID"": 13,
      ""NAME"": ""Norwood Ave"",
      ""Longitude"": ""-73.87962599910783"",
      ""Latitude"": ""40.68152000045683"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""Z-rush hours AM westbound, PM eastbound, J-all other times"" 
    },
    {
      ""ID"": 14,
      ""NAME"": ""104th-102nd Sts"",
      ""Longitude"": ""-73.84443500029684"",
      ""Latitude"": ""40.69516599823373"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""Z-rush hours AM westbound, PM eastbound, J-all other times"" 
    },
    {
      ""ID"": 15,
      ""NAME"": ""DeKalb Ave"",
      ""Longitude"": ""-73.98177094440949"",
      ""Latitude"": ""40.690648119969794"",
      ""LINE"": ""B-D-N-Q-R"",
      ""NOTES"": ""B-weekdays and evenings, D-all other times, N-nights, R-all other times, Q-all times"" 
    },
    {
      ""ID"": 16,
      ""NAME"": ""Beach 105th St"",
      ""Longitude"": ""-73.82758075034528"",
      ""Latitude"": ""40.58326843810286"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-rush hours AM northbound, PM southbound, S Broad Channel to Rockaway Park-all times"" 
    },
    {
      ""ID"": 17,
      ""NAME"": ""Beach 90th St"",
      ""Longitude"": ""-73.81365140419632"",
      ""Latitude"": ""40.58809156457325"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-rush hours AM northbound, PM southbound, S Broad Channel to Rockaway Park-all times"" 
    },
    {
      ""ID"": 18,
      ""NAME"": ""Freeman St"",
      ""Longitude"": ""-73.89175225349464"",
      ""Latitude"": ""40.829987446384116"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 19,
      ""NAME"": ""Intervale Ave"",
      ""Longitude"": ""-73.89661738461646"",
      ""Latitude"": ""40.822142131170786"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 20,
      ""NAME"": ""182nd-183rd Sts"",
      ""Longitude"": ""-73.90074099998965"",
      ""Latitude"": ""40.85609299881864"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 21,
      ""NAME"": ""174th-175th Sts"",
      ""Longitude"": ""-73.91013600050078"",
      ""Latitude"": ""40.84589999983414"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 22,
      ""NAME"": ""167th St"",
      ""Longitude"": ""-73.91843200082253"",
      ""Latitude"": ""40.83376899862797"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 23,
      ""NAME"": ""Mets - Willets  "",
      ""Longitude"": ""-73.8456249984179"",
      ""Latitude"": ""40.75462199881262"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 24,
      ""NAME"": ""Junction Blvd"",
      ""Longitude"": ""-73.86952700103515"",
      ""Latitude"": ""40.74914499948836"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 25,
      ""NAME"": ""Flushing - Main St"",
      ""Longitude"": ""-73.83003000262508"",
      ""Latitude"": ""40.75959999915012"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 26,
      ""NAME"": ""Buhre Ave"",
      ""Longitude"": ""-73.83256900003744"",
      ""Latitude"": ""40.846809998885504"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6 Express-weekdays AM southbound, PM northbound, 6-all other times"" 
    },
    {
      ""ID"": 27,
      ""NAME"": ""3rd Ave - 138th St"",
      ""Longitude"": ""-73.92613800014134"",
      ""Latitude"": ""40.81047600117261"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 28,
      ""NAME"": ""Castle Hill Ave"",
      ""Longitude"": ""-73.85122199961472"",
      ""Latitude"": ""40.83425499825462"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6 Express-weekdays AM southbound, PM northbound, 6-all other times"" 
    },
    {
      ""ID"": 29,
      ""NAME"": ""Brooklyn Bridge - City Hall"",
      ""Longitude"": ""-74.0041310005885"",
      ""Latitude"": ""40.713064999433136"",
      ""LINE"": ""4-5-6-6 Express"",
      ""NOTES"": ""4,6-all times, 5-all times exc nights, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 30,
      ""NAME"": ""Zerega Ave"",
      ""Longitude"": ""-73.8470359987544"",
      ""Latitude"": ""40.836488000608156"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6 Express-weekdays AM southbound, PM northbound, 6-all other times"" 
    },
    {
      ""ID"": 31,
      ""NAME"": ""Grand Central - 42nd St"",
      ""Longitude"": ""-73.9767132992584"",
      ""Latitude"": ""40.75180742981634"",
      ""LINE"": ""4-5-6-6 Express"",
      ""NOTES"": ""4,6-all times, 5-all times exc nights, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 32,
      ""NAME"": ""33rd St"",
      ""Longitude"": ""-73.98207600148947"",
      ""Latitude"": ""40.74608099909145"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 33,
      ""NAME"": ""96th St"",
      ""Longitude"": ""-73.9510700015425"",
      ""Latitude"": ""40.78567199998607"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 34,
      ""NAME"": ""77th St"",
      ""Longitude"": ""-73.95987399886047"",
      ""Latitude"": ""40.77362000074615"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 35,
      ""NAME"": ""Chauncey St"",
      ""Longitude"": ""-73.91038357033376"",
      ""Latitude"": ""40.68285130087804"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""Z-rush hours AM westbound, PM eastbound, J-all other times"" 
    },
    {
      ""ID"": 36,
      ""NAME"": ""Union St"",
      ""Longitude"": ""-73.98310999909673"",
      ""Latitude"": ""40.67731566735096"",
      ""LINE"": ""D-N-R"",
      ""NOTES"": ""D,N-nights, R-all other times"" 
    },
    {
      ""ID"": 37,
      ""NAME"": ""Elmhurst Ave"",
      ""Longitude"": ""-73.8820347465864"",
      ""Latitude"": ""40.74237007972169"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 38,
      ""NAME"": ""Ralph Ave"",
      ""Longitude"": ""-73.92078599933306"",
      ""Latitude"": ""40.678822000873375"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 39,
      ""NAME"": ""Pelham Pkwy"",
      ""Longitude"": ""-73.86748067850041"",
      ""Latitude"": ""40.8571924091606"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 40,
      ""NAME"": ""Gun Hill Rd"",
      ""Longitude"": ""-73.86613410538703"",
      ""Latitude"": ""40.877839385172024"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 41,
      ""NAME"": ""Nereid Ave, 238 St"",
      ""Longitude"": ""-73.8543153107622"",
      ""Latitude"": ""40.898286515575286"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound""
    },
    {
      ""ID"": 42,
      ""NAME"": ""Franklin Ave"",
      ""Longitude"": ""-73.9580997367769"",
      ""Latitude"": ""40.67076515344894"",
      ""LINE"": ""2-3-4-5"",
      ""NOTES"": ""2,4-all times, 3-all times exc nights, 5-weekdays"" 
    },
    {
      ""ID"": 43,
      ""NAME"": ""Simpson St"",
      ""Longitude"": ""-73.89306639507903"",
      ""Latitude"": ""40.823976841237396"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 44,
      ""NAME"": ""Bronx Park East"",
      ""Longitude"": ""-73.86835609178098"",
      ""Latitude"": ""40.848768666338934"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 45,
      ""NAME"": ""Winthrop St"",
      ""Longitude"": ""-73.95007934590994"",
      ""Latitude"": ""40.65665931376077"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-weekdays"" 
    },
    {
      ""ID"": 46,
      ""NAME"": ""Van Siclen Ave"",
      ""Longitude"": ""-73.88940491730106"",
      ""Latitude"": ""40.665517963059635"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 47,
      ""NAME"": ""149th St - Grand Concourse"",
      ""Longitude"": ""-73.9273847542618"",
      ""Latitude"": ""40.81830344372315"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 48,
      ""NAME"": ""161st St - Yankee Stadium"",
      ""Longitude"": ""-73.92569199505733"",
      ""Latitude"": ""40.82823032742169"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 49,
      ""NAME"": ""Lexington Ave - 59th St"",
      ""Longitude"": ""-73.9679670004732"",
      ""Latitude"": ""40.762526000304575"",
      ""LINE"": ""4-5-6-6 Express"",
      ""NOTES"": ""4,6-all times, 5-all times exc nights, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 50,
      ""NAME"": ""E 149th St"",
      ""Longitude"": ""-73.90409799875945"",
      ""Latitude"": ""40.81211799827203"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 51,
      ""NAME"": ""Morrison Av - Soundview"",
      ""Longitude"": ""-73.87451599929486"",
      ""Latitude"": ""40.82952100156747"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 52,
      ""NAME"": ""Whitlock Ave"",
      ""Longitude"": ""-73.8862829985325"",
      ""Latitude"": ""40.82652500055904"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 53,
      ""NAME"": ""St Lawrence Ave"",
      ""Longitude"": ""-73.86761799923673"",
      ""Latitude"": ""40.8315090005233"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 54,
      ""NAME"": ""Woodside - 61st St"",
      ""Longitude"": ""-73.90298400173006"",
      ""Latitude"": ""40.745630001138395"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 55,
      ""NAME"": ""Far Rockaway - Mott Ave"",
      ""Longitude"": ""-73.75540499924732"",
      ""Latitude"": ""40.603995001687544"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 56,
      ""NAME"": ""72nd St"",
      ""Longitude"": ""-73.976336575218"",
      ""Latitude"": ""40.77551939729258"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 57,
      ""NAME"": ""96th St"",
      ""Longitude"": ""-73.96460245687166"",
      ""Latitude"": ""40.79161879767014"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 58,
      ""NAME"": ""168th St"",
      ""Longitude"": ""-73.93956099985425"",
      ""Latitude"": ""40.84071899990795"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 59,
      ""NAME"": ""Kingsbridge Rd"",
      ""Longitude"": ""-73.8935090000331"",
      ""Latitude"": ""40.86697799999945"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times"" 
    },
    {
      ""ID"": 60,
      ""NAME"": ""42nd St - Bryant Pk"",
      ""Longitude"": ""-73.98459099904711"",
      ""Latitude"": ""40.754184001312545"",
      ""LINE"": ""B-D-F-M"",
      ""NOTES"": ""B,M-weekdays and evenings, D,F-all times"" 
    },
    {
      ""ID"": 61,
      ""NAME"": ""Prospect Park"",
      ""Longitude"": ""-73.96203130426609"",
      ""Latitude"": ""40.6616334551018"",
      ""LINE"": ""B-Q-S"",
      ""NOTES"": ""B-weekdays and evenings, Q,S to Franklin Av-Fulton St-all times"" 
    },
    {
      ""ID"": 62,
      ""NAME"": ""55th St"",
      ""Longitude"": ""-73.99534882595742"",
      ""Latitude"": ""40.63147876093745"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 63,
      ""NAME"": ""Jamaica - Van Wyck"",
      ""Longitude"": ""-73.81701287135405"",
      ""Latitude"": ""40.70289855287313"",
      ""LINE"": ""E"",
      ""NOTES"": ""E-all times"" 
    },
    {
      ""ID"": 64,
      ""NAME"": ""Kew Gardens - Union Tpke"",
      ""Longitude"": ""-73.8303702709878"",
      ""Latitude"": ""40.714034819571026"",
      ""LINE"": ""E-F"",
      ""NOTES"": ""E,F-all times"" 
    },
    {
      ""ID"": 65,
      ""NAME"": ""Sutphin Blvd - Archer Av"",
      ""Longitude"": ""-73.80800471963833"",
      ""Latitude"": ""40.700382424235"",
      ""LINE"": ""E-J-Z"",
      ""NOTES"": ""E,J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 66,
      ""NAME"": ""Court Sq - 23rd St"",
      ""Longitude"": ""-73.94605470266329"",
      ""Latitude"": ""40.747768121414325"",
      ""LINE"": ""E-M"",
      ""NOTES"": ""E-all times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 67,
      ""NAME"": ""67th Ave"",
      ""Longitude"": ""-73.85286048434907"",
      ""Latitude"": ""40.726505475813006"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 68,
      ""NAME"": ""Grand Ave - Newtown"",
      ""Longitude"": ""-73.87722085669182"",
      ""Latitude"": ""40.736813418197144"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 69,
      ""NAME"": ""Ditmas Ave"",
      ""Longitude"": ""-73.97817199965161"",
      ""Latitude"": ""40.63611866666291"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 70,
      ""NAME"": ""Classon Ave"",
      ""Longitude"": ""-73.95999000137212"",
      ""Latitude"": ""40.68888900026455"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 71,
      ""NAME"": ""Broadway"",
      ""Longitude"": ""-73.95031225606621"",
      ""Latitude"": ""40.706126576274166"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 72,
      ""NAME"": ""Lorimer St"",
      ""Longitude"": ""-73.95024799996972"",
      ""Latitude"": ""40.71407200064717"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 73,
      ""NAME"": ""Sutter Ave"",
      ""Longitude"": ""-73.9019160004208"",
      ""Latitude"": ""40.66914500061398"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 74,
      ""NAME"": ""Wilson Ave"",
      ""Longitude"": ""-73.90395860491864"",
      ""Latitude"": ""40.68886654246024"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 75,
      ""NAME"": ""Halsey St"",
      ""Longitude"": ""-73.9166388842194"",
      ""Latitude"": ""40.686415270704344"",
      ""LINE"": ""J"",
      ""NOTES"": ""J-all times"" 
    },
    {
      ""ID"": 76,
      ""NAME"": ""Lorimer St"",
      ""Longitude"": ""-73.94735499884204"",
      ""Latitude"": ""40.703844000042096"",
      ""LINE"": ""J-M"",
      ""NOTES"": ""J-all times, skips weekdays AM westbound, PM eastbound, M-all times exc nights"" 
    },
    {
      ""ID"": 77,
      ""NAME"": ""8th Ave"",
      ""Longitude"": ""-74.01151599772157"",
      ""Latitude"": ""40.634970999647166"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 78,
      ""NAME"": ""36th Ave"",
      ""Longitude"": ""-73.929861999118"",
      ""Latitude"": ""40.7564420005104"",
      ""LINE"": ""N-W"",
      ""NOTES"": ""N-all times, W part time"" 
    },
    {
      ""ID"": 79,
      ""NAME"": ""Broadway"",
      ""Longitude"": ""-73.92582299919906"",
      ""Latitude"": ""40.761431998800546"",
      ""LINE"": ""N-W"",
      ""NOTES"": ""N-all times, W part time"" 
    },
    {
      ""ID"": 80,
      ""NAME"": ""Times Sq - 42nd St"",
      ""Longitude"": ""-73.98676800153976"",
      ""Latitude"": ""40.75461199851542"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N,Q-all times, R-all times exc nights, W part time"" 
    },
    {
      ""ID"": 81,
      ""NAME"": ""Grand Central - 42nd St"",
      ""Longitude"": ""-73.97918899989101"",
      ""Latitude"": ""40.75276866674217"",
      ""LINE"": ""S"",
      ""NOTES"": ""S to Times Sq-all times exc nights, closed nights-use 7"" 
    },
    {
      ""ID"": 82,
      ""NAME"": ""Park Pl"",
      ""Longitude"": ""-73.95762400074634"",
      ""Latitude"": ""40.67477166685263"",
      ""LINE"": ""S"",
      ""NOTES"": ""S Franklin Av-Fulton St to Prospect Park-all times"" 
    },
    {
      ""ID"": 83,
      ""NAME"": ""111th St"",
      ""Longitude"": ""-73.83216299845388"",
      ""Latitude"": ""40.68433100001238"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""S Euclid Av to Ozone Park-Lefferts Blvd-nights, A-all other times"" 
    },
    {
      ""ID"": 84,
      ""NAME"": ""W 4th St - Washington Sq, Lower"",
      ""Longitude"": ""-74.00030814755975"",
      ""Latitude"": ""40.732254493367876"",
      ""LINE"": ""B-D-F-M"",
      ""NOTES"": ""B,M-weekdays and evenings, D,F-all times""
    },
    {
      ""ID"": 85,
      ""NAME"": ""51st St"",
      ""Longitude"": ""-73.97192000069982"",
      ""Latitude"": ""40.75710699989316"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 86,
      ""NAME"": ""86th St"",
      ""Longitude"": ""-73.97621799859327"",
      ""Latitude"": ""40.78864400073892"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 87,
      ""NAME"": ""233rd St"",
      ""Longitude"": ""-73.85736239521543"",
      ""Latitude"": ""40.89314324138378"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 88,
      ""NAME"": ""66th St - Lincoln Ctr"",
      ""Longitude"": ""-73.98220899995783"",
      ""Latitude"": ""40.77344000052039"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 89,
      ""NAME"": ""Hunts   Ave"",
      ""Longitude"": ""-73.89054900017344"",
      ""Latitude"": ""40.82094799852307"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 90,
      ""NAME"": ""Canal St"",
      ""Longitude"": ""-74.0062770001748"",
      ""Latitude"": ""40.72285399778783"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 91,
      ""NAME"": ""Middletown Rd"",
      ""Longitude"": ""-73.83632199755944"",
      ""Latitude"": ""40.84386300128381"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6 Express-weekdays AM southbound, PM northbound, 6-all other times"" 
    },
    {
      ""ID"": 92,
      ""NAME"": ""23rd St"",
      ""Longitude"": ""-73.98659900207888"",
      ""Latitude"": ""40.739864000474604"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 93,
      ""NAME"": ""Court Sq"",
      ""Longitude"": ""-73.94526400039679"",
      ""Latitude"": ""40.74702299889643"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 94,
      ""NAME"": ""59th St - Columbus Circle"",
      ""Longitude"": ""-73.98192900232715"",
      ""Latitude"": ""40.76824700063689"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 95,
      ""NAME"": ""Hunters   Ave"",
      ""Longitude"": ""-73.9489160009391"",
      ""Latitude"": ""40.74221599986316"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 96,
      ""NAME"": ""23rd St"",
      ""Longitude"": ""-73.9956570016487"",
      ""Latitude"": ""40.74408099989751"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 97,
      ""NAME"": ""Houston St"",
      ""Longitude"": ""-74.00536700180581"",
      ""Latitude"": ""40.728251000730204"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 98,
      ""NAME"": ""104th St"",
      ""Longitude"": ""-73.83768300060997"",
      ""Latitude"": ""40.681711001091195"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""S Euclid Av to Ozone Park-Lefferts Blvd-nights, A-all other times"" 
    },
    {
      ""ID"": 99,
      ""NAME"": ""Broad Channel"",
      ""Longitude"": ""-73.81583268782963"",
      ""Latitude"": ""40.60840218069683"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A,S to Rockaway Park-all times"" 
    },
    {
      ""ID"": 100,
      ""NAME"": ""Ocean Pkwy"",
      ""Longitude"": ""-73.96850099975177"",
      ""Latitude"": ""40.57631166708091"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 101,
      ""NAME"": ""Vernon Blvd - Jackson Ave"",
      ""Longitude"": ""-73.95358099875249"",
      ""Latitude"": ""40.74262599969749"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 102,
      ""NAME"": ""68th St - Hunter College"",
      ""Longitude"": ""-73.96387000158042"",
      ""Latitude"": ""40.76814100049679"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 103,
      ""NAME"": ""Queensboro Plz"",
      ""Longitude"": ""-73.9401635351909"",
      ""Latitude"": ""40.750635651014804"",
      ""LINE"": ""7-7 Express-N-W"",
      ""NOTES"": ""7,N-all times, 7 Express-rush hours AM westbound, PM eastbound, W part time"" 
    },
    {
      ""ID"": 104,
      ""NAME"": ""Rockaway Blvd"",
      ""Longitude"": ""-73.8438529979573"",
      ""Latitude"": ""40.680428999588415"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-all times, S Euclid Av to Ozone Park-Lefferts Blvd-nights"" 
    },
    {
      ""ID"": 105,
      ""NAME"": ""Union Sq - 14th St"",
      ""Longitude"": ""-73.98995099881881"",
      ""Latitude"": ""40.734673000996125"",
      ""LINE"": ""4-5-6-6 Express"",
      ""NOTES"": ""4,6-all times, 5-all times exc nights, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 106,
      ""NAME"": ""Bedford - Nostrand Aves"",
      ""Longitude"": ""-73.95352200064022"",
      ""Latitude"": ""40.68962700158444"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 107,
      ""NAME"": ""15th St - Prospect Park"",
      ""Longitude"": ""-73.97973580592873"",
      ""Latitude"": ""40.66003568810021"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 108,
      ""NAME"": ""7th Ave"",
      ""Longitude"": ""-73.98025117900944"",
      ""Latitude"": ""40.66624469001985"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 109,
      ""NAME"": ""Ft Hamilton Pkwy"",
      ""Longitude"": ""-73.97577599917474"",
      ""Latitude"": ""40.65078166803418"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 110,
      ""NAME"": ""Church Ave"",
      ""Longitude"": ""-73.97972116229084"",
      ""Latitude"": ""40.64427200012998"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 111,
      ""NAME"": ""Beverly Rd"",
      ""Longitude"": ""-73.96435779623125"",
      ""Latitude"": ""40.64390459860419"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 112,
      ""NAME"": ""Church Ave"",
      ""Longitude"": ""-73.96288246192114"",
      ""Latitude"": ""40.65049324646484"",
      ""LINE"": ""B-Q"",
      ""NOTES"": ""B-weekdays and evenings, Q-all times"" 
    },
    {
      ""ID"": 113,
      ""NAME"": ""Newkirk Ave"",
      ""Longitude"": ""-73.96269486837261"",
      ""Latitude"": ""40.63514193733789"",
      ""LINE"": ""B-Q"",
      ""NOTES"": ""B-weekdays and evenings, Q-all times"" 
    },
    {
      ""ID"": 114,
      ""NAME"": ""Parkside Ave"",
      ""Longitude"": ""-73.96145343987648"",
      ""Latitude"": ""40.65507304163716"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 115,
      ""NAME"": ""Grand Army Plaza"",
      ""Longitude"": ""-73.9709563319228"",
      ""Latitude"": ""40.6752946951032"",
      ""LINE"": ""2-3-4"",
      ""NOTES"": ""4-nights, 3-all other times, 2-all times"" 
    },
    {
      ""ID"": 116,
      ""NAME"": ""Atlantic Av - Barclay's Center"",
      ""Longitude"": ""-73.97754993539385"",
      ""Latitude"": ""40.68442016526762"",
      ""LINE"": ""2-3-4-5"",
      ""NOTES"": ""2,4-all times, 3-all times exc nights, 5-weekdays"" 
    },
    {
      ""ID"": 117,
      ""NAME"": ""Rockaway Ave"",
      ""Longitude"": ""-73.91194599726617"",
      ""Latitude"": ""40.678339999883505"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 118,
      ""NAME"": ""Fulton St"",
      ""Longitude"": ""-73.97537499833149"",
      ""Latitude"": ""40.68711899950771"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 119,
      ""NAME"": ""Clinton - Washington Aves"",
      ""Longitude"": ""-73.9667959986695"",
      ""Latitude"": ""40.68809400106055"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 120,
      ""NAME"": ""7th Ave"",
      ""Longitude"": ""-73.97285279191024"",
      ""Latitude"": ""40.67710217983294"",
      ""LINE"": ""B-Q"",
      ""NOTES"": ""B-weekdays and evenings, Q-all times"" 
    },
    {
      ""ID"": 121,
      ""NAME"": ""Atlantic Av - Barclay's Center"",
      ""Longitude"": ""-73.97678343963167"",
      ""Latitude"": ""40.684488323453685"",
      ""LINE"": ""B-Q"",
      ""NOTES"": ""B-weekdays and evenings, Q-all times"" 
    },
    {
      ""ID"": 122,
      ""NAME"": ""Atlantic Av - Barclay's Center"",
      ""Longitude"": ""-73.97880999956767"",
      ""Latitude"": ""40.683665667279435"",
      ""LINE"": ""D-N-Q-R"",
      ""NOTES"": ""D,N-all times, R-all times exc nights"" 
    },
    {
      ""ID"": 123,
      ""NAME"": ""Borough Hall"",
      ""Longitude"": ""-73.99015100090539"",
      ""Latitude"": ""40.692403999991036"",
      ""LINE"": ""4-5"",
      ""NOTES"": ""4-all times, 5-weekdays"" 
    },
    {
      ""ID"": 124,
      ""NAME"": ""Aqueduct Racetrack"",
      ""Longitude"": ""-73.83591899965162"",
      ""Latitude"": ""40.672096999172844"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-to Manhattan only, racing days only"" 
    },
    {
      ""ID"": 125,
      ""NAME"": ""Morris Park"",
      ""Longitude"": ""-73.86049500117254"",
      ""Latitude"": ""40.85436399966426"",
      ""LINE"": ""5"",
      ""NOTES"": ""5-all times"" 
    },
    {
      ""ID"": 126,
      ""NAME"": ""Pelham Pkwy"",
      ""Longitude"": ""-73.85535900043564"",
      ""Latitude"": ""40.858984999820116"",
      ""LINE"": ""5"",
      ""NOTES"": ""5-all times"" 
    },
    {
      ""ID"": 127,
      ""NAME"": ""Nostrand Ave"",
      ""Longitude"": ""-73.95042600099683"",
      ""Latitude"": ""40.68043800006226"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 128,
      ""NAME"": ""Nevins St"",
      ""Longitude"": ""-73.98040679874578"",
      ""Latitude"": ""40.68831058019022"",
      ""LINE"": ""2-3-4-5"",
      ""NOTES"": ""2,4-all times, 3-all times exc nights, 5-weekdays"" 
    },
    {
      ""ID"": 129,
      ""NAME"": ""Eastern Pkwy - Bklyn Museum"",
      ""Longitude"": ""-73.96422203748425"",
      ""Latitude"": ""40.67203223545925"",
      ""LINE"": ""2-3-4"",
      ""NOTES"": ""4-nights, 3-all other times, 2-all times"" 
    },
    {
      ""ID"": 130,
      ""NAME"": ""Beverly Rd"",
      ""Longitude"": ""-73.94884798381702"",
      ""Latitude"": ""40.64512351894373"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-weekdays"" 
    },
    {
      ""ID"": 131,
      ""NAME"": ""Church Ave"",
      ""Longitude"": ""-73.94945514035334"",
      ""Latitude"": ""40.6508606878022"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-weekdays"" 
    },
    {
      ""ID"": 132,
      ""NAME"": ""Newkirk Ave"",
      ""Longitude"": ""-73.94829990822407"",
      ""Latitude"": ""40.63999124275311"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-weekdays"" 
    },
    {
      ""ID"": 133,
      ""NAME"": ""Brooklyn College - Flatbush Ave"",
      ""Longitude"": ""-73.94754120734406"",
      ""Latitude"": ""40.63284240700742"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-weekdays"" 
    },
    {
      ""ID"": 134,
      ""NAME"": ""Sterling St"",
      ""Longitude"": ""-73.95072891124937"",
      ""Latitude"": ""40.6627729934283"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-weekdays"" 
    },
    {
      ""ID"": 135,
      ""NAME"": ""Crown Hts - Utica Ave"",
      ""Longitude"": ""-73.93293256081851"",
      ""Latitude"": ""40.66897831107809"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""3-all times exc nights, 4-all times"" 
    },
    {
      ""ID"": 136,
      ""NAME"": ""Kingston Ave"",
      ""Longitude"": ""-73.94215978392963"",
      ""Latitude"": ""40.66948144864978"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 137,
      ""NAME"": ""Nassau Ave"",
      ""Longitude"": ""-73.95118300016523"",
      ""Latitude"": ""40.724479997808274"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 138,
      ""NAME"": ""Green  Ave"",
      ""Longitude"": ""-73.95442500146235"",
      ""Latitude"": ""40.73126699971465"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 139,
      ""NAME"": ""Marcy Ave"",
      ""Longitude"": ""-73.95783200075729"",
      ""Latitude"": ""40.708383000017925"",
      ""LINE"": ""J-M-Z"",
      ""NOTES"": ""J-all times, M-all times exc nights, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 140,
      ""NAME"": ""Hewes St"",
      ""Longitude"": ""-73.95348800038457"",
      ""Latitude"": ""40.706889998054"",
      ""LINE"": ""J-M"",
      ""NOTES"": ""J-all times, skips weekdays AM westbound, PM eastbound, M-all times exc nights"" 
    },
    {
      ""ID"": 141,
      ""NAME"": ""138th St - Grand Concourse"",
      ""Longitude"": ""-73.92984899935611"",
      ""Latitude"": ""40.81322399958908"",
      ""LINE"": ""4-5"",
      ""NOTES"": ""4-all times, skips rush hours AM southbound, PM northbound, 5-all times exc nights"" 
    },
    {
      ""ID"": 142,
      ""NAME"": ""5th Ave - 53rd St"",
      ""Longitude"": ""-73.9752485052734"",
      ""Latitude"": ""40.76008683231326"",
      ""LINE"": ""E-M"",
      ""NOTES"": ""E-all times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 143,
      ""NAME"": ""Lexington Ave - 53rd St"",
      ""Longitude"": ""-73.96907237490204"",
      ""Latitude"": ""40.75746830782865"",
      ""LINE"": ""E-M"",
      ""NOTES"": ""E-all times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 144,
      ""NAME"": ""28th St"",
      ""Longitude"": ""-73.98869800128737"",
      ""Latitude"": ""40.74545399979951"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N-all times, R-all times exc nights, part time"" 
    },
    {
      ""ID"": 145,
      ""NAME"": ""Herald Sq - 34th St"",
      ""Longitude"": ""-73.9879368338264"",
      ""Latitude"": ""40.74964456009442"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N,Q-all times, R-all times exc nights"" 
    },
    {
      ""ID"": 146,
      ""NAME"": ""1st Ave"",
      ""Longitude"": ""-73.98168087489128"",
      ""Latitude"": ""40.73097497580066"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 147,
      ""NAME"": ""Times Sq - 42nd St"",
      ""Longitude"": ""-73.98622899953202"",
      ""Latitude"": ""40.755983000570076"",
      ""LINE"": ""S"",
      ""NOTES"": ""S to Grand Central-all times exc nights, closed nights-use 7"" 
    },
    {
      ""ID"": 148,
      ""NAME"": ""Metropolitan Ave"",
      ""Longitude"": ""-73.9514239994525"",
      ""Latitude"": ""40.71277400073426"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 149,
      ""NAME"": ""Grand St"",
      ""Longitude"": ""-73.94049699874644"",
      ""Latitude"": ""40.71157600064823"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 150,
      ""NAME"": ""Graham Ave"",
      ""Longitude"": ""-73.94394399869037"",
      ""Latitude"": ""40.714575998363635"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 151,
      ""NAME"": ""Bedford Ave"",
      ""Longitude"": ""-73.95666499806525"",
      ""Latitude"": ""40.71717399858899"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 152,
      ""NAME"": ""Montrose Ave"",
      ""Longitude"": ""-73.93979284713505"",
      ""Latitude"": ""40.70739106438455"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 153,
      ""NAME"": ""Long Island City - Court Sq"",
      ""Longitude"": ""-73.94381559597835"",
      ""Latitude"": ""40.74630503357145"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 154,
      ""NAME"": ""21st St"",
      ""Longitude"": ""-73.9495999997552"",
      ""Latitude"": ""40.7441286664954"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 155,
      ""NAME"": ""39th Ave"",
      ""Longitude"": ""-73.93285137679598"",
      ""Latitude"": ""40.75276306140845"",
      ""LINE"": ""N-W"",
      ""NOTES"": ""N-all times, W part time"" 
    },
    {
      ""ID"": 156,
      ""NAME"": ""145th St"",
      ""Longitude"": ""-73.95035999879713"",
      ""Latitude"": ""40.82655099962194"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 157,
      ""NAME"": ""157th St"",
      ""Longitude"": ""-73.94488999901047"",
      ""Latitude"": ""40.8340410001399"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 158,
      ""NAME"": ""96th St"",
      ""Longitude"": ""-73.97232299915696"",
      ""Latitude"": ""40.79391900121471"",
      ""LINE"": ""1-2-3"",
      ""NOTES"": ""1,2,3-all times"" 
    },
    {
      ""ID"": 159,
      ""NAME"": ""103rd St"",
      ""Longitude"": ""-73.96837899960818"",
      ""Latitude"": ""40.799446000334825"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 160,
      ""NAME"": ""Central Park North, 110th St"",
      ""Longitude"": ""-73.95182200176913"",
      ""Latitude"": ""40.79907499977324"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2,3-all times""
    },
    {
      ""ID"": 161,
      ""NAME"": ""103rd St"",
      ""Longitude"": ""-73.96137008267617"",
      ""Latitude"": ""40.796060739904526"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 162,
      ""NAME"": ""72nd St"",
      ""Longitude"": ""-73.98197000159583"",
      ""Latitude"": ""40.77845300068614"",
      ""LINE"": ""1-2-3"",
      ""NOTES"": ""1,2,3-all times"" 
    },
    {
      ""ID"": 163,
      ""NAME"": ""81st St"",
      ""Longitude"": ""-73.97209794937208"",
      ""Latitude"": ""40.78134608418206"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 164,
      ""NAME"": ""75th Ave"",
      ""Longitude"": ""-73.83692369387158"",
      ""Latitude"": ""40.71804465348743"",
      ""LINE"": ""E-F"",
      ""NOTES"": ""E-evenings, weekends, nights, F-all times"" 
    },
    {
      ""ID"": 165,
      ""NAME"": ""86th St"",
      ""Longitude"": ""-73.96882849429672"",
      ""Latitude"": ""40.78582304678557"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 166,
      ""NAME"": ""Cathedral Pkwy, 110th St"",
      ""Longitude"": ""-73.9668470005456"",
      ""Latitude"": ""40.80396699961484"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times""
    },
    {
      ""ID"": 167,
      ""NAME"": ""116th St - Columbia University"",
      ""Longitude"": ""-73.96410999757751"",
      ""Latitude"": ""40.807722001230864"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 168,
      ""NAME"": ""125th St"",
      ""Longitude"": ""-73.94549500011411"",
      ""Latitude"": ""40.807753999182815"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2,3-all times"" 
    },
    {
      ""ID"": 169,
      ""NAME"": ""135th St"",
      ""Longitude"": ""-73.94077000106708"",
      ""Latitude"": ""40.8142290003391"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2,3-all times"" 
    },
    {
      ""ID"": 170,
      ""NAME"": ""116th St"",
      ""Longitude"": ""-73.94962500096905"",
      ""Latitude"": ""40.802097999133004"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2,3-all times"" 
    },
    {
      ""ID"": 171,
      ""NAME"": ""Tremont Ave"",
      ""Longitude"": ""-73.90522700122354"",
      ""Latitude"": ""40.850409999510234"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times"" 
    },
    {
      ""ID"": 172,
      ""NAME"": ""137th St - City College"",
      ""Longitude"": ""-73.95367600087873"",
      ""Latitude"": ""40.82200799968475"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 173,
      ""NAME"": ""145th St"",
      ""Longitude"": ""-73.93624499873299"",
      ""Latitude"": ""40.82042099969279"",
      ""LINE"": ""3"",
      ""NOTES"": ""3-all times, exit only northbound"" 
    },
    {
      ""ID"": 174,
      ""NAME"": ""176th St"",
      ""Longitude"": ""-73.91179399884471"",
      ""Latitude"": ""40.8484800012369"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 175,
      ""NAME"": ""Burnside Ave"",
      ""Longitude"": ""-73.9076840015997"",
      ""Latitude"": ""40.85345300155693"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 176,
      ""NAME"": ""170th St"",
      ""Longitude"": ""-73.91339999846983"",
      ""Latitude"": ""40.83930599964156"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 177,
      ""NAME"": ""168th St"",
      ""Longitude"": ""-73.94013299907257"",
      ""Latitude"": ""40.840555999148535"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 178,
      ""NAME"": ""181st St"",
      ""Longitude"": ""-73.9335959996056"",
      ""Latitude"": ""40.84950499974065"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 179,
      ""NAME"": ""191st St"",
      ""Longitude"": ""-73.92941199742039"",
      ""Latitude"": ""40.85522500175836"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 180,
      ""NAME"": ""175th St"",
      ""Longitude"": ""-73.93970399761596"",
      ""Latitude"": ""40.84739100072403"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 181,
      ""NAME"": ""Beach 44th St"",
      ""Longitude"": ""-73.77601299999507"",
      ""Latitude"": ""40.59294299908617"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 182,
      ""NAME"": ""Beach 60th St"",
      ""Longitude"": ""-73.7885219980118"",
      ""Latitude"": ""40.59237400121235"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 183,
      ""NAME"": ""Beach 98th St"",
      ""Longitude"": ""-73.82052058959523"",
      ""Latitude"": ""40.58538569133279"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-rush hours AM northbound, PM southbound, S Broad Channel to Rockaway Park-all times"" 
    },
    {
      ""ID"": 184,
      ""NAME"": ""Rockaway Park - Beach 116 St"",
      ""Longitude"": ""-73.83559008701239"",
      ""Latitude"": ""40.580955865573515"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-rush hours AM northbound, PM southbound, S to Broad Channel-all times"" 
    },
    {
      ""ID"": 185,
      ""NAME"": ""Beach 36th St"",
      ""Longitude"": ""-73.76817499939688"",
      ""Latitude"": ""40.59539800166876"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 186,
      ""NAME"": ""Beach 25th St"",
      ""Longitude"": ""-73.76135299762073"",
      ""Latitude"": ""40.60006600105881"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 187,
      ""NAME"": ""Parsons Blvd"",
      ""Longitude"": ""-73.80328900021885"",
      ""Latitude"": ""40.707571999615695"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 188,
      ""NAME"": ""169th St"",
      ""Longitude"": ""-73.79347419927721"",
      ""Latitude"": ""40.710517502784"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 189,
      ""NAME"": ""103rd St - Corona Plaza"",
      ""Longitude"": ""-73.86269999830412"",
      ""Latitude"": ""40.749865000555545"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 190,
      ""NAME"": ""111th St"",
      ""Longitude"": ""-73.85533399834884"",
      ""Latitude"": ""40.75172999941711"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 191,
      ""NAME"": ""63rd Dr - Rego Park"",
      ""Longitude"": ""-73.86161820097203"",
      ""Latitude"": ""40.729763972422425"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 192,
      ""NAME"": ""Grant Ave"",
      ""Longitude"": ""-73.86504999877702"",
      ""Latitude"": ""40.67704400054478"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-all times, S Euclid Av to Ozone Park-Lefferts Blvd-nights"" 
    },
    {
      ""ID"": 193,
      ""NAME"": ""79th St"",
      ""Longitude"": ""-73.97991700056134"",
      ""Latitude"": ""40.78393399959032"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 194,
      ""NAME"": ""Atlantic Ave"",
      ""Longitude"": ""-73.9030969995401"",
      ""Latitude"": ""40.67534466640805"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 195,
      ""NAME"": ""Christopher St - Sheridan Sq"",
      ""Longitude"": ""-74.00290599855235"",
      ""Latitude"": ""40.73342200104225"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 196,
      ""NAME"": ""Ozone Park - Lefferts Blvd"",
      ""Longitude"": ""-73.82579799906613"",
      ""Latitude"": ""40.68595099878361"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""S to Euclid Av-nights, A-all other times"" 
    },
    {
      ""ID"": 197,
      ""NAME"": ""Times Sq - 42nd St"",
      ""Longitude"": ""-73.98769099825152"",
      ""Latitude"": ""40.755477001982506"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 198,
      ""NAME"": ""W 8th St - NY Aquarium"",
      ""Longitude"": ""-73.97595787413822"",
      ""Latitude"": ""40.576033818103646"",
      ""LINE"": ""F-Q"",
      ""NOTES"": ""F,Q-all times"" 
    },
    {
      ""ID"": 199,
      ""NAME"": ""28th St"",
      ""Longitude"": ""-73.99336500134324"",
      ""Latitude"": ""40.74721499918219"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 200,
      ""NAME"": ""28th St"",
      ""Longitude"": ""-73.98426400110407"",
      ""Latitude"": ""40.743069999259035"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 201,
      ""NAME"": ""Pelham Bay Park"",
      ""Longitude"": ""-73.82812100059289"",
      ""Latitude"": ""40.85246199951662"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6 Express-weekdays AM southbound, PM northbound, 6-all other times"" 
    },
    {
      ""ID"": 202,
      ""NAME"": ""Westchester Sq - E Tremont Ave"",
      ""Longitude"": ""-73.84295199925012"",
      ""Latitude"": ""40.839892001013915"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6 Express-weekdays AM southbound, PM northbound, 6-all other times"" 
    },
    {
      ""ID"": 203,
      ""NAME"": ""18th St"",
      ""Longitude"": ""-73.99787100060406"",
      ""Latitude"": ""40.741039999802105"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 204,
      ""NAME"": ""Grand Central - 42nd St"",
      ""Longitude"": ""-73.97604100111508"",
      ""Latitude"": ""40.751431000286864"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 205,
      ""NAME"": ""Beach 67th St"",
      ""Longitude"": ""-73.7969239998421"",
      ""Latitude"": ""40.59092700078133"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 206,
      ""NAME"": ""W 4th St - Washington Sq, Upper"",
      ""Longitude"": ""-74.00049500225435"",
      ""Latitude"": ""40.73233799774325"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A,E-all times, C-all times exc nights""
    },
    {
      ""ID"": 207,
      ""NAME"": ""85th St - Forest Pky"",
      ""Longitude"": ""-73.86008700006875"",
      ""Latitude"": ""40.69242699966103"",
      ""LINE"": ""J"",
      ""NOTES"": ""J-all times"" 
    },
    {
      ""ID"": 208,
      ""NAME"": ""Woodhaven Blvd"",
      ""Longitude"": ""-73.85205199740794"",
      ""Latitude"": ""40.69370399880105"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 209,
      ""NAME"": ""111th St"",
      ""Longitude"": ""-73.83679338454697"",
      ""Latitude"": ""40.697114810696476"",
      ""LINE"": ""J"",
      ""NOTES"": ""J-all times"" 
    },
    {
      ""ID"": 210,
      ""NAME"": ""121st St"",
      ""Longitude"": ""-73.82834900017954"",
      ""Latitude"": ""40.700481998515315"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""Z-rush hours AM westbound, PM eastbound, J-all other times"" 
    },
    {
      ""ID"": 211,
      ""NAME"": ""Halsey St"",
      ""Longitude"": ""-73.90393400118631"",
      ""Latitude"": ""40.69551800114878"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 212,
      ""NAME"": ""Myrtle - Wyckoff Aves"",
      ""Longitude"": ""-73.9109757182647"",
      ""Latitude"": ""40.699471062427136"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 213,
      ""NAME"": ""New Lots Ave"",
      ""Longitude"": ""-73.88411070800329"",
      ""Latitude"": ""40.6663149325969"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 214,
      ""NAME"": ""Van Siclen Ave"",
      ""Longitude"": ""-73.8903580002471"",
      ""Latitude"": ""40.67270999906104"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 215,
      ""NAME"": ""Cleveland St"",
      ""Longitude"": ""-73.8851940021643"",
      ""Latitude"": ""40.679777998961164"",
      ""LINE"": ""J"",
      ""NOTES"": ""J-all times"" 
    },
    {
      ""ID"": 216,
      ""NAME"": ""Livonia Ave"",
      ""Longitude"": ""-73.90056237226057"",
      ""Latitude"": ""40.66405727094644"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 217,
      ""NAME"": ""Junius St"",
      ""Longitude"": ""-73.90244864183562"",
      ""Latitude"": ""40.66358900181724"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 218,
      ""NAME"": ""Rockaway Ave"",
      ""Longitude"": ""-73.90895833584449"",
      ""Latitude"": ""40.66261748815223"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 219,
      ""NAME"": ""Canarsie - Rockaway Pkwy"",
      ""Longitude"": ""-73.90185000017287"",
      ""Latitude"": ""40.64665366739528"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 220,
      ""NAME"": ""E 105th St"",
      ""Longitude"": ""-73.89954769388724"",
      ""Latitude"": ""40.65046878544699"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 221,
      ""NAME"": ""Saratoga Ave"",
      ""Longitude"": ""-73.91633025007947"",
      ""Latitude"": ""40.6615297898075"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 222,
      ""NAME"": ""Sutter Ave - Rutland Road"",
      ""Longitude"": ""-73.92252118536001"",
      ""Latitude"": ""40.66476678877493"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 223,
      ""NAME"": ""New Lots Ave"",
      ""Longitude"": ""-73.89927796057142"",
      ""Latitude"": ""40.65891477368527"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 224,
      ""NAME"": ""Broadway Junction"",
      ""Longitude"": ""-73.90428999746412"",
      ""Latitude"": ""40.67936600147369"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 225,
      ""NAME"": ""Alabama Ave"",
      ""Longitude"": ""-73.89852600159652"",
      ""Latitude"": ""40.676998000003756"",
      ""LINE"": ""J"",
      ""NOTES"": ""J-all times"" 
    },
    {
      ""ID"": 226,
      ""NAME"": ""Shepherd Ave"",
      ""Longitude"": ""-73.88074999747269"",
      ""Latitude"": ""40.6741300014559"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 227,
      ""NAME"": ""Crescent St"",
      ""Longitude"": ""-73.87392925215778"",
      ""Latitude"": ""40.68315265707736"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 228,
      ""NAME"": ""Cypress Hills"",
      ""Longitude"": ""-73.87332199882995"",
      ""Latitude"": ""40.689616000838754"",
      ""LINE"": ""J"",
      ""NOTES"": ""J-all times"" 
    },
    {
      ""ID"": 229,
      ""NAME"": ""75th St - Eldert Ln"",
      ""Longitude"": ""-73.86728799944963"",
      ""Latitude"": ""40.691290001246735"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""Z-rush hours AM westbound, PM eastbound, J-all other times"" 
    },
    {
      ""ID"": 230,
      ""NAME"": ""69th St"",
      ""Longitude"": ""-73.8964029993185"",
      ""Latitude"": ""40.746324999410284"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 231,
      ""NAME"": ""74th St - Broadway"",
      ""Longitude"": ""-73.8912051289911"",
      ""Latitude"": ""40.746867573829114"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 232,
      ""NAME"": ""Woodhaven Blvd - Queens Mall"",
      ""Longitude"": ""-73.86943208612348"",
      ""Latitude"": ""40.73309737380972"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 233,
      ""NAME"": ""Myrtle - Wyckoff Aves"",
      ""Longitude"": ""-73.91217899939602"",
      ""Latitude"": ""40.69945400090837"",
      ""LINE"": ""M"",
      ""NOTES"": ""M-all times"" 
    },
    {
      ""ID"": 234,
      ""NAME"": ""Seneca Ave"",
      ""Longitude"": ""-73.90758199885423"",
      ""Latitude"": ""40.70291899894902"",
      ""LINE"": ""M"",
      ""NOTES"": ""M-all times"" 
    },
    {
      ""ID"": 235,
      ""NAME"": ""DeKalb Ave"",
      ""Longitude"": ""-73.91823200219723"",
      ""Latitude"": ""40.70369299961644"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 236,
      ""NAME"": ""52nd St"",
      ""Longitude"": ""-73.91254899891254"",
      ""Latitude"": ""40.744149001021576"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 237,
      ""NAME"": ""46th St"",
      ""Longitude"": ""-73.91352174995538"",
      ""Latitude"": ""40.756316952608096"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 238,
      ""NAME"": ""Northern Blvd"",
      ""Longitude"": ""-73.90606508052358"",
      ""Latitude"": ""40.752824829236076"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 239,
      ""NAME"": ""46th St"",
      ""Longitude"": ""-73.91843500103973"",
      ""Latitude"": ""40.74313200060382"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 240,
      ""NAME"": ""82nd St - Jackson Hts"",
      ""Longitude"": ""-73.88369700071884"",
      ""Latitude"": ""40.747658999559135"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 241,
      ""NAME"": ""90th St - Elmhurst Av"",
      ""Longitude"": ""-73.87661299986985"",
      ""Latitude"": ""40.74840800060913"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 242,
      ""NAME"": ""Howard Beach - JFK Airport"",
      ""Longitude"": ""-73.83030100071032"",
      ""Latitude"": ""40.66047600004959"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 243,
      ""NAME"": ""Aqueduct - North Conduit Av"",
      ""Longitude"": ""-73.83405799948723"",
      ""Latitude"": ""40.668234001699815"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 244,
      ""NAME"": ""Briarwood - Van Wyck Blvd"",
      ""Longitude"": ""-73.82069263637443"",
      ""Latitude"": ""40.70916181536946"",
      ""LINE"": ""E-F"",
      ""NOTES"": ""E-evenings, weekends, nights, F-all times"" 
    },
    {
      ""ID"": 245,
      ""NAME"": ""Forest Hills - 71st Av"",
      ""Longitude"": ""-73.84451672012669"",
      ""Latitude"": ""40.72159430953587"",
      ""LINE"": ""E-F-M-R"",
      ""NOTES"": ""E,F-all times, M-weekdays and evenings, R-all times exc nights"" 
    },
    {
      ""ID"": 246,
      ""NAME"": ""Sutphin Blvd"",
      ""Longitude"": ""-73.81083299897232"",
      ""Latitude"": ""40.70541799906764"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 247,
      ""NAME"": ""Jamaica Ctr - Parsons / Archer"",
      ""Longitude"": ""-73.80109632298924"",
      ""Latitude"": ""40.70206737621188"",
      ""LINE"": ""E-J-Z"",
      ""NOTES"": ""E,J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 248,
      ""NAME"": ""225th St"",
      ""Longitude"": ""-73.86021461772737"",
      ""Latitude"": ""40.88802825863786"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 249,
      ""NAME"": ""Elder Ave"",
      ""Longitude"": ""-73.87915899874777"",
      ""Latitude"": ""40.82858400108929"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 250,
      ""NAME"": ""Longwood Ave"",
      ""Longitude"": ""-73.89643499897414"",
      ""Latitude"": ""40.816103999972405"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 251,
      ""NAME"": ""Astoria Blvd"",
      ""Longitude"": ""-73.91809500109238"",
      ""Latitude"": ""40.77003699949086"",
      ""LINE"": ""N-W"",
      ""NOTES"": ""N-all times, W part time"" 
    },
    {
      ""ID"": 252,
      ""NAME"": ""Astoria - Ditmars Blvd"",
      ""Longitude"": ""-73.9120340001031"",
      ""Latitude"": ""40.775035666523664"",
      ""LINE"": ""N-W"",
      ""NOTES"": ""N-all times, W part time"" 
    },
    {
      ""ID"": 253,
      ""NAME"": ""Jackson Ave"",
      ""Longitude"": ""-73.9077019387083"",
      ""Latitude"": ""40.81643746686396"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 254,
      ""NAME"": ""Prospect Ave"",
      ""Longitude"": ""-73.90177778730917"",
      ""Latitude"": ""40.81948726483844"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 255,
      ""NAME"": ""Cypress Ave"",
      ""Longitude"": ""-73.91404199994753"",
      ""Latitude"": ""40.8053680007636"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 256,
      ""NAME"": ""174th St"",
      ""Longitude"": ""-73.88769359812888"",
      ""Latitude"": ""40.837195550170605"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 257,
      ""NAME"": ""Allerton Ave"",
      ""Longitude"": ""-73.86723422851625"",
      ""Latitude"": ""40.86548337793927"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 258,
      ""NAME"": ""E 143rd St - St Mary's St"",
      ""Longitude"": ""-73.90765699936489"",
      ""Latitude"": ""40.80871900090143"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 259,
      ""NAME"": ""Kingsbridge Rd"",
      ""Longitude"": ""-73.89717400101743"",
      ""Latitude"": ""40.867760000885795"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 260,
      ""NAME"": ""Bedford Park Blvd - Lehman College"",
      ""Longitude"": ""-73.89006400069478"",
      ""Latitude"": ""40.87341199980121"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 261,
      ""NAME"": ""Harlem - 148 St"",
      ""Longitude"": ""-73.93647000005559"",
      ""Latitude"": ""40.82388000080457"",
      ""LINE"": ""3"",
      ""NOTES"": ""3-all times"" 
    },
    {
      ""ID"": 262,
      ""NAME"": ""Mt Eden Ave"",
      ""Longitude"": ""-73.9146849986034"",
      ""Latitude"": ""40.84443400092679"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 263,
      ""NAME"": ""Fordham Rd"",
      ""Longitude"": ""-73.89774900102401"",
      ""Latitude"": ""40.861295998683495"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times"" 
    },
    {
      ""ID"": 264,
      ""NAME"": ""170th St"",
      ""Longitude"": ""-73.91779099745928"",
      ""Latitude"": ""40.84007499993004"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 265,
      ""NAME"": ""Bedford Park Blvd"",
      ""Longitude"": ""-73.88713799889574"",
      ""Latitude"": ""40.87324399861646"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times"" 
    },
    {
      ""ID"": 266,
      ""NAME"": ""Marble Hill - 225th St"",
      ""Longitude"": ""-73.90983099923551"",
      ""Latitude"": ""40.87456099941789"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 267,
      ""NAME"": ""231st St"",
      ""Longitude"": ""-73.90483400107873"",
      ""Latitude"": ""40.87885599817935"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 268,
      ""NAME"": ""215th St"",
      ""Longitude"": ""-73.91527899954356"",
      ""Latitude"": ""40.86944399946045"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 269,
      ""NAME"": ""207th St"",
      ""Longitude"": ""-73.91881900132312"",
      ""Latitude"": ""40.864614000525854"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 270,
      ""NAME"": ""Inwood - 207th St"",
      ""Longitude"": ""-73.91989900100465"",
      ""Latitude"": ""40.86807199999737"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 271,
      ""NAME"": ""Van Cortlandt Park - 242nd St"",
      ""Longitude"": ""-73.89858300049647"",
      ""Latitude"": ""40.88924800011476"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 272,
      ""NAME"": ""West Farms Sq - E Tremont Av"",
      ""Longitude"": ""-73.87996127877184"",
      ""Latitude"": ""40.84020763241799"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 273,
      ""NAME"": ""219th St"",
      ""Longitude"": ""-73.8625097078866"",
      ""Latitude"": ""40.883887974625274"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 274,
      ""NAME"": ""Mosholu Pkwy"",
      ""Longitude"": ""-73.88465499988732"",
      ""Latitude"": ""40.87974999947229"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 275,
      ""NAME"": ""Norwood - 205th St"",
      ""Longitude"": ""-73.87885499918691"",
      ""Latitude"": ""40.87481100011182"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 276,
      ""NAME"": ""Burke Ave"",
      ""Longitude"": ""-73.86705361747603"",
      ""Latitude"": ""40.87125880254771"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 277,
      ""NAME"": ""Baychester Ave"",
      ""Longitude"": ""-73.83859099802153"",
      ""Latitude"": ""40.87866300037311"",
      ""LINE"": ""5"",
      ""NOTES"": ""5-all times"" 
    },
    {
      ""ID"": 278,
      ""NAME"": ""Eastchester - Dyre Ave"",
      ""Longitude"": ""-73.8308340021742"",
      ""Latitude"": ""40.88829999901007"",
      ""LINE"": ""5"",
      ""NOTES"": ""5-all times"" 
    },
    {
      ""ID"": 279,
      ""NAME"": ""Jamaica - 179th St"",
      ""Longitude"": ""-73.78381700176453"",
      ""Latitude"": ""40.712645666744045"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 280,
      ""NAME"": ""Wakefield - 241st St"",
      ""Longitude"": ""-73.8506199987954"",
      ""Latitude"": ""40.903125000541245"",
      ""LINE"": ""2"",
      ""NOTES"": ""2-all times"" 
    },
    {
      ""ID"": 281,
      ""NAME"": ""Botanic Garden"",
      ""Longitude"": ""-73.95924499945693"",
      ""Latitude"": ""40.670342666584396"",
      ""LINE"": ""S"",
      ""NOTES"": ""S Franklin Av-Fulton St to Prospect Park-all times"" 
    },
    {
      ""ID"": 282,
      ""NAME"": ""Bushwick - Aberdeen"",
      ""Longitude"": ""-73.90526176305106"",
      ""Latitude"": ""40.68286062551184"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 283,
      ""NAME"": ""Broadway Junction"",
      ""Longitude"": ""-73.90311757920684"",
      ""Latitude"": ""40.67845624842869"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 284,
      ""NAME"": ""Gun Hill Rd"",
      ""Longitude"": ""-73.84638400151765"",
      ""Latitude"": ""40.86952599962676"",
      ""LINE"": ""5"",
      ""NOTES"": ""5-all times"" 
    },
    {
      ""ID"": 285,
      ""NAME"": ""E 180th St"",
      ""Longitude"": ""-73.87334609510884"",
      ""Latitude"": ""40.8418630412186"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2,5-all times"" 
    },
    {
      ""ID"": 286,
      ""NAME"": ""Dyckman St"",
      ""Longitude"": ""-73.92553600006474"",
      ""Latitude"": ""40.86053100138796"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 287,
      ""NAME"": ""125th St"",
      ""Longitude"": ""-73.95837200097044"",
      ""Latitude"": ""40.815580999978934"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 288,
      ""NAME"": ""Franklin Ave - Fulton St"",
      ""Longitude"": ""-73.95582700110425"",
      ""Latitude"": ""40.68059566598263"",
      ""LINE"": ""S"",
      ""NOTES"": ""S to Prospect Park-all times"" 
    },
    {
      ""ID"": 289,
      ""NAME"": ""149th St - Grand Concourse"",
      ""Longitude"": ""-73.92672247438611"",
      ""Latitude"": ""40.81833014409742"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights"" 
    },
    {
      ""ID"": 290,
      ""NAME"": ""3rd Ave - 149th St"",
      ""Longitude"": ""-73.91779152760981"",
      ""Latitude"": ""40.816029252510006"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5-all times exc nights"" 
    },
    {
      ""ID"": 291,
      ""NAME"": ""167th St"",
      ""Longitude"": ""-73.92139999784426"",
      ""Latitude"": ""40.83553699933672"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 292,
      ""NAME"": ""Brook Ave"",
      ""Longitude"": ""-73.91923999909432"",
      ""Latitude"": ""40.80756599987699"",
      ""LINE"": ""6"",
      ""NOTES"": ""6-all times"" 
    },
    {
      ""ID"": 293,
      ""NAME"": ""33rd St"",
      ""Longitude"": ""-73.93099699953838"",
      ""Latitude"": ""40.74458699983993"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 294,
      ""NAME"": ""40th St"",
      ""Longitude"": ""-73.9240159984882"",
      ""Latitude"": ""40.74378100149132"",
      ""LINE"": ""7"",
      ""NOTES"": ""7-all times"" 
    },
    {
      ""ID"": 295,
      ""NAME"": ""145th St"",
      ""Longitude"": ""-73.94408792823116"",
      ""Latitude"": ""40.824766360871905"",
      ""LINE"": ""A-B-C-D"",
      ""NOTES"": ""A,D-all times, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 296,
      ""NAME"": ""155th St"",
      ""Longitude"": ""-73.93820899811622"",
      ""Latitude"": ""40.8301349999812"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 297,
      ""NAME"": ""161st St - Yankee Stadium"",
      ""Longitude"": ""-73.92565099775477"",
      ""Latitude"": ""40.827904998845845"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-rush hours, D-all times, skips rush hours AM southbound, PM northbound"" 
    },
    {
      ""ID"": 298,
      ""NAME"": ""Utica Ave"",
      ""Longitude"": ""-73.93072899914027"",
      ""Latitude"": ""40.67936399950546"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 299,
      ""NAME"": ""Steinway St"",
      ""Longitude"": ""-73.9205264716827"",
      ""Latitude"": ""40.75698735912575"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-nights, R-all other times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 300,
      ""NAME"": ""Kosciuszko St"",
      ""Longitude"": ""-73.92850899927413"",
      ""Latitude"": ""40.69317200129202"",
      ""LINE"": ""J"",
      ""NOTES"": ""J-all times"" 
    },
    {
      ""ID"": 301,
      ""NAME"": ""Gates Ave"",
      ""Longitude"": ""-73.92215600150752"",
      ""Latitude"": ""40.689583999013905"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""Z-rush hours AM westbound, PM eastbound, J-all other times"" 
    },
    {
      ""ID"": 302,
      ""NAME"": ""Central Ave"",
      ""Longitude"": ""-73.92724299902838"",
      ""Latitude"": ""40.69787300011831"",
      ""LINE"": ""M"",
      ""NOTES"": ""M-all times"" 
    },
    {
      ""ID"": 303,
      ""NAME"": ""Knickerbocker Ave"",
      ""Longitude"": ""-73.91972000188625"",
      ""Latitude"": ""40.69866000123805"",
      ""LINE"": ""M"",
      ""NOTES"": ""M-all times"" 
    },
    {
      ""ID"": 304,
      ""NAME"": ""30th Ave"",
      ""Longitude"": ""-73.9214790001739"",
      ""Latitude"": ""40.76677866673298"",
      ""LINE"": ""N-W"",
      ""NOTES"": ""N-all times, W part time"" 
    },
    {
      ""ID"": 305,
      ""NAME"": ""Jefferson St"",
      ""Longitude"": ""-73.9229130000312"",
      ""Latitude"": ""40.706606665988716"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 306,
      ""NAME"": ""Morgan Ave"",
      ""Longitude"": ""-73.93314700024209"",
      ""Latitude"": ""40.70615166680729"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 307,
      ""NAME"": ""Queens Plz"",
      ""Longitude"": ""-73.93713823965695"",
      ""Latitude"": ""40.74891771986323"",
      ""LINE"": ""E-M-R"",
      ""NOTES"": ""E-all times, M-weekdays and evenings, R-all times exc nights"" 
    },
    {
      ""ID"": 308,
      ""NAME"": ""18th Ave"",
      ""Longitude"": ""-73.97697099965796"",
      ""Latitude"": ""40.62975466638584"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 309,
      ""NAME"": ""77th St"",
      ""Longitude"": ""-74.0255099996266"",
      ""Latitude"": ""40.629741666886915"",
      ""LINE"": ""R"",
      ""NOTES"": ""R-all times"" 
    },
    {
      ""ID"": 310,
      ""NAME"": ""Bay Ridge Ave"",
      ""Longitude"": ""-74.02337699950728"",
      ""Latitude"": ""40.63496666682377"",
      ""LINE"": ""R"",
      ""NOTES"": ""R-all times"" 
    },
    {
      ""ID"": 311,
      ""NAME"": ""50th St"",
      ""Longitude"": ""-73.9946587805514"",
      ""Latitude"": ""40.636260890961395"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 312,
      ""NAME"": ""Ft Hamilton Pkwy"",
      ""Longitude"": ""-74.00535100046275"",
      ""Latitude"": ""40.63138566722445"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 313,
      ""NAME"": ""25th Ave"",
      ""Longitude"": ""-73.98682900011477"",
      ""Latitude"": ""40.59770366695856"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 314,
      ""NAME"": ""Bay Pky"",
      ""Longitude"": ""-73.9936762000529"",
      ""Latitude"": ""40.601950461572315"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 315,
      ""NAME"": ""20th Ave"",
      ""Longitude"": ""-73.98452199846113"",
      ""Latitude"": ""40.617108999866005"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 316,
      ""NAME"": ""18th Ave"",
      ""Longitude"": ""-73.99045399865993"",
      ""Latitude"": ""40.620686997680025"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 317,
      ""NAME"": ""Bay Ridge - 95th St"",
      ""Longitude"": ""-74.03087600085765"",
      ""Latitude"": ""40.61662166725951"",
      ""LINE"": ""R"",
      ""NOTES"": ""R-all times"" 
    },
    {
      ""ID"": 318,
      ""NAME"": ""86th St"",
      ""Longitude"": ""-74.0283979999864"",
      ""Latitude"": ""40.62268666715025"",
      ""LINE"": ""R"",
      ""NOTES"": ""R-all times"" 
    },
    {
      ""ID"": 319,
      ""NAME"": ""79th St"",
      ""Longitude"": ""-74.00058287431507"",
      ""Latitude"": ""40.61315892569516"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 320,
      ""NAME"": ""71st St"",
      ""Longitude"": ""-73.99884094850685"",
      ""Latitude"": ""40.61925870977273"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 321,
      ""NAME"": ""20th Ave"",
      ""Longitude"": ""-73.99817432157568"",
      ""Latitude"": ""40.60467699816932"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 322,
      ""NAME"": ""18th Ave"",
      ""Longitude"": ""-74.00159259239406"",
      ""Latitude"": ""40.60773573171741"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 323,
      ""NAME"": ""62nd St"",
      ""Longitude"": ""-73.99685724994863"",
      ""Latitude"": ""40.626224462922195"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 324,
      ""NAME"": ""New Utrecht Ave"",
      ""Longitude"": ""-73.99635300025969"",
      ""Latitude"": ""40.62484166725887"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 325,
      ""NAME"": ""Ave U"",
      ""Longitude"": ""-73.97337641974885"",
      ""Latitude"": ""40.59592482551748"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 326,
      ""NAME"": ""Kings Hwy"",
      ""Longitude"": ""-73.9723553085244"",
      ""Latitude"": ""40.603258405128265"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 327,
      ""NAME"": ""Brighton Beach"",
      ""Longitude"": ""-73.96135378598797"",
      ""Latitude"": ""40.577710196642435"",
      ""LINE"": ""B-Q"",
      ""NOTES"": ""B-weekdays and evenings, Q-all times"" 
    },
    {
      ""ID"": 328,
      ""NAME"": ""Sheepshead Bay"",
      ""Longitude"": ""-73.95405791257907"",
      ""Latitude"": ""40.58654754707536"",
      ""LINE"": ""B-Q"",
      ""NOTES"": ""B-weekdays and evenings, Q-all times"" 
    },
    {
      ""ID"": 329,
      ""NAME"": ""Ave U"",
      ""Longitude"": ""-73.95581122316301"",
      ""Latitude"": ""40.59930895095475"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 330,
      ""NAME"": ""Kings Hwy"",
      ""Longitude"": ""-73.95760873538083"",
      ""Latitude"": ""40.608638645396006"",
      ""LINE"": ""B-Q"",
      ""NOTES"": ""B-weekdays and evenings, Q-all times"" 
    },
    {
      ""ID"": 331,
      ""NAME"": ""Ave U"",
      ""Longitude"": ""-73.97908400099428"",
      ""Latitude"": ""40.597235999920436"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 332,
      ""NAME"": ""Kings Hwy"",
      ""Longitude"": ""-73.98037300229343"",
      ""Latitude"": ""40.60405899980493"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 333,
      ""NAME"": ""Neptune Ave"",
      ""Longitude"": ""-73.97459272818807"",
      ""Latitude"": ""40.580738758491464"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 334,
      ""NAME"": ""Ave X"",
      ""Longitude"": ""-73.97426599968905"",
      ""Latitude"": ""40.589449666625285"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 335,
      ""NAME"": ""Bay 50th St"",
      ""Longitude"": ""-73.98376500045946"",
      ""Latitude"": ""40.58884066651933"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 336,
      ""NAME"": ""Gravesend - 86th St"",
      ""Longitude"": ""-73.97818899936274"",
      ""Latitude"": ""40.59246500088859"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 337,
      ""NAME"": ""Ave P"",
      ""Longitude"": ""-73.97300281528751"",
      ""Latitude"": ""40.608842808949916"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 338,
      ""NAME"": ""Ave N"",
      ""Longitude"": ""-73.97404850873143"",
      ""Latitude"": ""40.61435671190883"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 339,
      ""NAME"": ""Bay Pky"",
      ""Longitude"": ""-73.9752569782215"",
      ""Latitude"": ""40.62073162316788"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 340,
      ""NAME"": ""Ave M"",
      ""Longitude"": ""-73.9592431052215"",
      ""Latitude"": ""40.617397744443736"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 341,
      ""NAME"": ""Bay Pky"",
      ""Longitude"": ""-73.98178001069293"",
      ""Latitude"": ""40.61145578989005"",
      ""LINE"": ""N"",
      ""NOTES"": ""N-all times"" 
    },
    {
      ""ID"": 342,
      ""NAME"": ""Ave I"",
      ""Longitude"": ""-73.97606933170925"",
      ""Latitude"": ""40.62501744019143"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 343,
      ""NAME"": ""Ave J"",
      ""Longitude"": ""-73.96069316246925"",
      ""Latitude"": ""40.625022819915166"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 344,
      ""NAME"": ""Ave H"",
      ""Longitude"": ""-73.96151793942495"",
      ""Latitude"": ""40.62920837758969"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 345,
      ""NAME"": ""Neck Rd"",
      ""Longitude"": ""-73.95507827493762"",
      ""Latitude"": ""40.59532169111695"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 346,
      ""NAME"": ""21st St - Queensbridge"",
      ""Longitude"": ""-73.94193761457447"",
      ""Latitude"": ""40.75373927087553"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 347,
      ""NAME"": ""50th St"",
      ""Longitude"": ""-73.98598400026407"",
      ""Latitude"": ""40.76245599925997"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A-nights, C-all other times, E-all times"" 
    },
    {
      ""ID"": 348,
      ""NAME"": ""7th Ave"",
      ""Longitude"": ""-73.98169782344476"",
      ""Latitude"": ""40.76297015245628"",
      ""LINE"": ""B-D-E"",
      ""NOTES"": ""D,E-all times, B-weekdays and evenings"" 
    },
    {
      ""ID"": 349,
      ""NAME"": ""47th-50th Sts - Rockefeller Ctr"",
      ""Longitude"": ""-73.98133100227702"",
      ""Latitude"": ""40.75864100159815"",
      ""LINE"": ""B-D-F-M"",
      ""NOTES"": ""B,M-weekdays and evenings, D,F-all times"" 
    },
    {
      ""ID"": 350,
      ""NAME"": ""57th St"",
      ""Longitude"": ""-73.97736800085171"",
      ""Latitude"": ""40.76408500081713"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 351,
      ""NAME"": ""Lexington Ave - 63rd St"",
      ""Longitude"": ""-73.96608964413245"",
      ""Latitude"": ""40.76461809442373"",
      ""LINE"": ""F-Q"",
      ""NOTES"": ""F-all times, Q all times"" 
    },
    {
      ""ID"": 352,
      ""NAME"": ""Roosevelt Island - Main St"",
      ""Longitude"": ""-73.95323499978866"",
      ""Latitude"": ""40.75917199967108"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 353,
      ""NAME"": ""59th St - Columbus Circle"",
      ""Longitude"": ""-73.98164872301398"",
      ""Latitude"": ""40.768249531776064"",
      ""LINE"": ""A-B-C-D"",
      ""NOTES"": ""A,D-all times, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 354,
      ""NAME"": ""49th St"",
      ""Longitude"": ""-73.98420956591096"",
      ""Latitude"": ""40.759801973870694"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N-all times, Q-all times exc weekends, R-all times exc nights, W part time"" 
    },
    {
      ""ID"": 355,
      ""NAME"": ""57th St"",
      ""Longitude"": ""-73.98072973372128"",
      ""Latitude"": ""40.76456552501829"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N,Q-all times, R-all times exc nights, W part time"" 
    },
    {
      ""ID"": 356,
      ""NAME"": ""5th Ave - 59th St"",
      ""Longitude"": ""-73.97334700047045"",
      ""Latitude"": ""40.764810999755284"",
      ""LINE"": ""N-R-W"",
      ""NOTES"": ""N-all times, R-all times exc nights, W part time"" 
    },
    {
      ""ID"": 357,
      ""NAME"": ""Lexington Ave - 59th St"",
      ""Longitude"": ""-73.96737501711436"",
      ""Latitude"": ""40.762708855394564"",
      ""LINE"": ""N-R-W"",
      ""NOTES"": ""N-all times, R-all times exc nights, W part time"" 
    },
    {
      ""ID"": 358,
      ""NAME"": ""34th St - Penn Station"",
      ""Longitude"": ""-73.99105699913983"",
      ""Latitude"": ""40.75037300003949"",
      ""LINE"": ""1-2-3"",
      ""NOTES"": ""1,2,3-all times"" 
    },
    {
      ""ID"": 359,
      ""NAME"": ""Times Sq - 42nd St"",
      ""Longitude"": ""-73.98749500051885"",
      ""Latitude"": ""40.75528999995681"",
      ""LINE"": ""1-2-3"",
      ""NOTES"": ""1,2,3-all times"" 
    },
    {
      ""ID"": 360,
      ""NAME"": ""Fulton St"",
      ""Longitude"": ""-74.00762309323994"",
      ""Latitude"": ""40.71016216530185"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 361,
      ""NAME"": ""Chambers St"",
      ""Longitude"": ""-74.00858473570133"",
      ""Latitude"": ""40.714111000774025"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 362,
      ""NAME"": ""42nd St - Port Authority Bus Term"",
      ""Longitude"": ""-73.98973500085859"",
      ""Latitude"": ""40.757307998551504"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A,E-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 363,
      ""NAME"": ""Myrtle-Willoughby Aves"",
      ""Longitude"": ""-73.94906699890156"",
      ""Latitude"": ""40.69461899903765"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 364,
      ""NAME"": ""Flushing Ave"",
      ""Longitude"": ""-73.9502340010257"",
      ""Latitude"": ""40.70037666622154"",
      ""LINE"": ""G"",
      ""NOTES"": ""G-all times"" 
    },
    {
      ""ID"": 365,
      ""NAME"": ""23rd St"",
      ""Longitude"": ""-73.99276500471389"",
      ""Latitude"": ""40.742954317826005"",
      ""LINE"": ""F-M"",
      ""NOTES"": ""F-all times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 366,
      ""NAME"": ""Herald Sq - 34th St"",
      ""Longitude"": ""-73.98777189072918"",
      ""Latitude"": ""40.74978939990011"",
      ""LINE"": ""B-D-F-M"",
      ""NOTES"": ""B,M-weekdays and evenings, D,F-all times"" 
    },
    {
      ""ID"": 367,
      ""NAME"": ""Hoyt - Schermerhorn Sts"",
      ""Longitude"": ""-73.98503624034139"",
      ""Latitude"": ""40.68840847580642"",
      ""LINE"": ""A-C-G"",
      ""NOTES"": ""A,G-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 368,
      ""NAME"": ""Jay St - MetroTech"",
      ""Longitude"": ""-73.98721815267317"",
      ""Latitude"": ""40.692470636847084"",
      ""LINE"": ""A-C-F"",
      ""NOTES"": ""A,F-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 369,
      ""NAME"": ""East Broadway"",
      ""Longitude"": ""-73.99017700122197"",
      ""Latitude"": ""40.713855001020406"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 370,
      ""NAME"": ""Delancey St - Essex St"",
      ""Longitude"": ""-73.98807806807719"",
      ""Latitude"": ""40.71868074219453"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 371,
      ""NAME"": ""Lower East Side - 2nd Ave"",
      ""Longitude"": ""-73.98993800003434"",
      ""Latitude"": ""40.72340166574911"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 372,
      ""NAME"": ""Flushing Ave"",
      ""Longitude"": ""-73.94137734838365"",
      ""Latitude"": ""40.70040440298112"",
      ""LINE"": ""J-M"",
      ""NOTES"": ""J-all times, skips weekdays AM westbound, PM eastbound, M-all times exc nights"" 
    },
    {
      ""ID"": 373,
      ""NAME"": ""Myrtle Ave"",
      ""Longitude"": ""-73.9356230012996"",
      ""Latitude"": ""40.6971950005145"",
      ""LINE"": ""J-M-Z"",
      ""NOTES"": ""J,M-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 374,
      ""NAME"": ""4th Av - 9th St"",
      ""Longitude"": ""-73.98977899938897"",
      ""Latitude"": ""40.67027166728493"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 375,
      ""NAME"": ""Smith - 9th Sts"",
      ""Longitude"": ""-73.99589172790934"",
      ""Latitude"": ""40.67364106090412"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 376,
      ""NAME"": ""Bergen St"",
      ""Longitude"": ""-73.99075649573565"",
      ""Latitude"": ""40.68611054725977"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 377,
      ""NAME"": ""Jay St - MetroTech"",
      ""Longitude"": ""-73.98605667854612"",
      ""Latitude"": ""40.69225539645323"",
      ""LINE"": ""N-R"",
      ""NOTES"": ""N-nights, R-all other times"" 
    },
    {
      ""ID"": 378,
      ""NAME"": ""Court St"",
      ""Longitude"": ""-73.99181830901125"",
      ""Latitude"": ""40.694196480776995"",
      ""LINE"": ""N-R"",
      ""NOTES"": ""N-nights, R-all other times"" 
    },
    {
      ""ID"": 379,
      ""NAME"": ""Union Sq - 14th St"",
      ""Longitude"": ""-73.99053886181645"",
      ""Latitude"": ""40.73587226699812"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N,Q-all times, R-all times exc nights"" 
    },
    {
      ""ID"": 380,
      ""NAME"": ""23rd St"",
      ""Longitude"": ""-73.98934400102907"",
      ""Latitude"": ""40.74130266729"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N-all times, Q-nights, R-all times exc nights"" 
    },
    {
      ""ID"": 381,
      ""NAME"": ""Prospect Ave"",
      ""Longitude"": ""-73.99287200067424"",
      ""Latitude"": ""40.66541366712979"",
      ""LINE"": ""D-N-R"",
      ""NOTES"": ""D,N-nights, R-all other times"" 
    },
    {
      ""ID"": 382,
      ""NAME"": ""4th Av - 9th St"",
      ""Longitude"": ""-73.98830199974512"",
      ""Latitude"": ""40.670846666842756"",
      ""LINE"": ""D-N-R"",
      ""NOTES"": ""D,N-nights, R-all other times"" 
    },
    {
      ""ID"": 383,
      ""NAME"": ""3rd Ave"",
      ""Longitude"": ""-73.98575000112093"",
      ""Latitude"": ""40.73269099971662"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 384,
      ""NAME"": ""Union Sq - 14th St"",
      ""Longitude"": ""-73.99066976901818"",
      ""Latitude"": ""40.73476331217923"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 385,
      ""NAME"": ""Liberty Ave"",
      ""Longitude"": ""-73.89654800103929"",
      ""Latitude"": ""40.67454199987086"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 386,
      ""NAME"": ""Broadway Junction"",
      ""Longitude"": ""-73.90531600055341"",
      ""Latitude"": ""40.67833366608023"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 387,
      ""NAME"": ""59th St"",
      ""Longitude"": ""-74.01788099953987"",
      ""Latitude"": ""40.6413616662838"",
      ""LINE"": ""N-R"",
      ""NOTES"": ""N,R-all times"" 
    },
    {
      ""ID"": 388,
      ""NAME"": ""45th St"",
      ""Longitude"": ""-74.01000600074939"",
      ""Latitude"": ""40.648938666612814"",
      ""LINE"": ""N-R"",
      ""NOTES"": ""N-nights, R-all times, skips nights northbound"" 
    },
    {
      ""ID"": 389,
      ""NAME"": ""36th St"",
      ""Longitude"": ""-74.00354899951809"",
      ""Latitude"": ""40.65514366633887"",
      ""LINE"": ""D-N-R"",
      ""NOTES"": ""D,N,R-all times"" 
    },
    {
      ""ID"": 390,
      ""NAME"": ""9th Ave"",
      ""Longitude"": ""-73.99444874451204"",
      ""Latitude"": ""40.64648407726636"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 391,
      ""NAME"": ""53rd St"",
      ""Longitude"": ""-74.01403399986317"",
      ""Latitude"": ""40.64506866735981"",
      ""LINE"": ""N-R"",
      ""NOTES"": ""N-nights, R-all times, skips nights northbound"" 
    },
    {
      ""ID"": 392,
      ""NAME"": ""Ft Hamilton Pkwy"",
      ""Longitude"": ""-73.9942022375285"",
      ""Latitude"": ""40.640912711444656"",
      ""LINE"": ""D"",
      ""NOTES"": ""D-all times"" 
    },
    {
      ""ID"": 393,
      ""NAME"": ""25th St"",
      ""Longitude"": ""-73.99809099974297"",
      ""Latitude"": ""40.66039666692321"",
      ""LINE"": ""D-N-R"",
      ""NOTES"": ""D,N-nights, R-all other times"" 
    },
    {
      ""ID"": 394,
      ""NAME"": ""Carroll St"",
      ""Longitude"": ""-73.99494697998841"",
      ""Latitude"": ""40.68027335170176"",
      ""LINE"": ""F-G"",
      ""NOTES"": ""F,G-all times"" 
    },
    {
      ""ID"": 395,
      ""NAME"": ""Spring St"",
      ""Longitude"": ""-74.00373899843763"",
      ""Latitude"": ""40.72622700129312"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A-nights, C-all other times, E-all times"" 
    },
    {
      ""ID"": 396,
      ""NAME"": ""181st St"",
      ""Longitude"": ""-73.93796900205011"",
      ""Latitude"": ""40.851694999744616"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 397,
      ""NAME"": ""190th St"",
      ""Longitude"": ""-73.93417999964333"",
      ""Latitude"": ""40.85902199892482"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 398,
      ""NAME"": ""116th St"",
      ""Longitude"": ""-73.95479778057312"",
      ""Latitude"": ""40.80505813344211"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 399,
      ""NAME"": ""125th St"",
      ""Longitude"": ""-73.95224799734774"",
      ""Latitude"": ""40.811071672994565"",
      ""LINE"": ""A-B-C-D"",
      ""NOTES"": ""A,D-all times, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 400,
      ""NAME"": ""Prince St"",
      ""Longitude"": ""-73.99770200045987"",
      ""Latitude"": ""40.72432866597571"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N-all times, Q-nights, R-all times exc nights"" 
    },
    {
      ""ID"": 401,
      ""NAME"": ""8th St - NYU"",
      ""Longitude"": ""-73.99250799849149"",
      ""Latitude"": ""40.73046499853991"",
      ""LINE"": ""N-Q-R-W"",
      ""NOTES"": ""N-all times, Q-nights, R-all times exc nights"" 
    },
    {
      ""ID"": 402,
      ""NAME"": ""Fulton St"",
      ""Longitude"": ""-74.00657099970202"",
      ""Latitude"": ""40.70941599925865"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 403,
      ""NAME"": ""Park Pl"",
      ""Longitude"": ""-74.00881099997359"",
      ""Latitude"": ""40.713050999077694"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 404,
      ""NAME"": ""Chambers St"",
      ""Longitude"": ""-74.00926600170112"",
      ""Latitude"": ""40.71547800011327"",
      ""LINE"": ""1-2-3"",
      ""NOTES"": ""1,2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 405,
      ""NAME"": ""Hoyt St"",
      ""Longitude"": ""-73.98506379575646"",
      ""Latitude"": ""40.69054418535472"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 406,
      ""NAME"": ""Borough Hall"",
      ""Longitude"": ""-73.98999799960687"",
      ""Latitude"": ""40.693218999611084"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 407,
      ""NAME"": ""183rd St"",
      ""Longitude"": ""-73.90387900151532"",
      ""Latitude"": ""40.85840700040842"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 408,
      ""NAME"": ""Fordham Rd"",
      ""Longitude"": ""-73.90103399921699"",
      ""Latitude"": ""40.86280299988937"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 409,
      ""NAME"": ""World Trade Center"",
      ""Longitude"": ""-74.00974461517701"",
      ""Latitude"": ""40.71256392680817"",
      ""LINE"": ""E"",
      ""NOTES"": ""E-all times"" 
    },
    {
      ""ID"": 410,
      ""NAME"": ""Canal St - Holland Tunnel"",
      ""Longitude"": ""-74.0052290023424"",
      ""Latitude"": ""40.72082400007119"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A,E-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 411,
      ""NAME"": ""155th St"",
      ""Longitude"": ""-73.94151400082208"",
      ""Latitude"": ""40.83051799929251"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 412,
      ""NAME"": ""163rd St - Amsterdam Av"",
      ""Longitude"": ""-73.93989200188344"",
      ""Latitude"": ""40.83601299923096"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 413,
      ""NAME"": ""Fulton St"",
      ""Longitude"": ""-74.00793800110387"",
      ""Latitude"": ""40.71002266658424"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 414,
      ""NAME"": ""Chambers St"",
      ""Longitude"": ""-74.00340673031336"",
      ""Latitude"": ""40.71323378962671"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 415,
      ""NAME"": ""Canal St"",
      ""Longitude"": ""-73.99982638545937"",
      ""Latitude"": ""40.71817387697391"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 416,
      ""NAME"": ""City Hall"",
      ""Longitude"": ""-74.00698581780337"",
      ""Latitude"": ""40.71327233111697"",
      ""LINE"": ""R-W"",
      ""NOTES"": ""N-nights, R-all other times"" 
    },
    {
      ""ID"": 417,
      ""NAME"": ""Canal St"",
      ""Longitude"": ""-74.0018260000577"",
      ""Latitude"": ""40.71946500105898"",
      ""LINE"": ""R-W"",
      ""NOTES"": ""N-nights, R-all other times"" 
    },
    {
      ""ID"": 418,
      ""NAME"": ""South Ferry"",
      ""Longitude"": ""-74.01316895919258"",
      ""Latitude"": ""40.701730507574474"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 419,
      ""NAME"": ""Bowling Green"",
      ""Longitude"": ""-74.01400799803432"",
      ""Latitude"": ""40.70491399928076"",
      ""LINE"": ""4-5"",
      ""NOTES"": ""4-all times, 5-all times exc nights"" 
    },
    {
      ""ID"": 420,
      ""NAME"": ""Wall St"",
      ""Longitude"": ""-74.01186199860112"",
      ""Latitude"": ""40.70755700086603"",
      ""LINE"": ""4-5"",
      ""NOTES"": ""4-all times, 5-weekdays"" 
    },
    {
      ""ID"": 421,
      ""NAME"": ""Whitehall St"",
      ""Longitude"": ""-74.0130072374272"",
      ""Latitude"": ""40.703142373599135"",
      ""LINE"": ""R-W"",
      ""NOTES"": ""N-nights, R-all other times"" 
    },
    {
      ""ID"": 422,
      ""NAME"": ""Rector St"",
      ""Longitude"": ""-74.01297456253795"",
      ""Latitude"": ""40.707744756294474"",
      ""LINE"": ""R-W"",
      ""NOTES"": ""N-nights, R-all other times"" 
    },
    {
      ""ID"": 423,
      ""NAME"": ""Fresh Pond Rd"",
      ""Longitude"": ""-73.8958980017196"",
      ""Latitude"": ""40.70622599823048"",
      ""LINE"": ""M"",
      ""NOTES"": ""M-all times"" 
    },
    {
      ""ID"": 424,
      ""NAME"": ""Middle Village - Metropolitan Ave"",
      ""Longitude"": ""-73.88957722978091"",
      ""Latitude"": ""40.711431305058255"",
      ""LINE"": ""M"",
      ""NOTES"": ""M-all times"" 
    },
    {
      ""ID"": 425,
      ""NAME"": ""Rector St"",
      ""Longitude"": ""-74.01378300119742"",
      ""Latitude"": ""40.707512999521775"",
      ""LINE"": ""1"",
      ""NOTES"": ""1-all times"" 
    },
    {
      ""ID"": 426,
      ""NAME"": ""Cortlandt St"",
      ""Longitude"": ""-74.01218800112292"",
      ""Latitude"": ""40.7118350008202"",
      ""LINE"": ""1"",
      ""NOTES"": ""Temporarily closed"" 
    },
    {
      ""ID"": 427,
      ""NAME"": ""Fulton St"",
      ""Longitude"": ""-74.00950899856461"",
      ""Latitude"": ""40.710367998822136"",
      ""LINE"": ""4-5"",
      ""NOTES"": ""4-all times, 5-weekdays"" 
    },
    {
      ""ID"": 428,
      ""NAME"": ""Broad St"",
      ""Longitude"": ""-74.01105599991755"",
      ""Latitude"": ""40.706476001106005"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 429,
      ""NAME"": ""Cortlandt St"",
      ""Longitude"": ""-74.01113196473266"",
      ""Latitude"": ""40.7105129841524"",
      ""LINE"": ""R-W"",
      ""NOTES"": ""N-nights, R-all other times"" 
    },
    {
      ""ID"": 430,
      ""NAME"": ""Wall St"",
      ""Longitude"": ""-74.00909999844257"",
      ""Latitude"": ""40.706820999753376"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 431,
      ""NAME"": ""Dyckman St"",
      ""Longitude"": ""-73.92727099960726"",
      ""Latitude"": ""40.865490998968916"",
      ""LINE"": ""A"",
      ""NOTES"": ""A-all times"" 
    },
    {
      ""ID"": 432,
      ""NAME"": ""Grand St"",
      ""Longitude"": ""-73.99375299913589"",
      ""Latitude"": ""40.71826699954992"",
      ""LINE"": ""B-D"",
      ""NOTES"": ""B-weekdays and evenings, D-all times"" 
    },
    {
      ""ID"": 433,
      ""NAME"": ""Broadway - Lafayette St"",
      ""Longitude"": ""-73.99620399876055"",
      ""Latitude"": ""40.725296998738045"",
      ""LINE"": ""B-D-F-M"",
      ""NOTES"": ""B,M-weekdays and evenings, D,F-all times"" 
    },
    {
      ""ID"": 434,
      ""NAME"": ""Bowery"",
      ""Longitude"": ""-73.99380690654237"",
      ""Latitude"": ""40.720246883147254"",
      ""LINE"": ""J-Z"",
      ""NOTES"": ""J-all times, Z-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 435,
      ""NAME"": ""Canal St"",
      ""Longitude"": ""-74.00105471306033"",
      ""Latitude"": ""40.718814263587134"",
      ""LINE"": ""N-Q"",
      ""NOTES"": ""N-all times, Q-weekdays and evenings"" 
    },
    {
      ""ID"": 436,
      ""NAME"": ""23rd St"",
      ""Longitude"": ""-73.99804100117201"",
      ""Latitude"": ""40.74590599939995"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A-nights, C-all other times, E-all times"" 
    },
    {
      ""ID"": 437,
      ""NAME"": ""34th St - Penn Station"",
      ""Longitude"": ""-73.99339099970578"",
      ""Latitude"": ""40.752287000775894"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A,E-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 438,
      ""NAME"": ""Jackson Hts - Roosevelt Av"",
      ""Longitude"": ""-73.89129866519697"",
      ""Latitude"": ""40.74653969115889"",
      ""LINE"": ""E-F-M-R"",
      ""NOTES"": ""E,F-all times, M-weekdays and evenings, R-all times exc nights"" 
    },
    {
      ""ID"": 439,
      ""NAME"": ""14th St"",
      ""Longitude"": ""-74.00020100063497"",
      ""Latitude"": ""40.737825999728116"",
      ""LINE"": ""1-2-3"",
      ""NOTES"": ""1,2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 440,
      ""NAME"": ""135th St"",
      ""Longitude"": ""-73.94753480879213"",
      ""Latitude"": ""40.817905559212676"",
      ""LINE"": ""A-B-C"",
      ""NOTES"": ""A-nights, B-weekdays and evenings, C-all times exc nights"" 
    },
    {
      ""ID"": 441,
      ""NAME"": ""14th St"",
      ""Longitude"": ""-73.99620899921355"",
      ""Latitude"": ""40.73822799969515"",
      ""LINE"": ""F-M"",
      ""NOTES"": ""F-all times, M-weekdays and evenings"" 
    },
    {
      ""ID"": 442,
      ""NAME"": ""6th Ave"",
      ""Longitude"": ""-73.99775078874781"",
      ""Latitude"": ""40.73774146981052"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 443,
      ""NAME"": ""8th Ave"",
      ""Longitude"": ""-74.00257800104762"",
      ""Latitude"": ""40.73977666638199"",
      ""LINE"": ""L"",
      ""NOTES"": ""L-all times"" 
    },
    {
      ""ID"": 444,
      ""NAME"": ""14th St"",
      ""Longitude"": ""-74.00168999937027"",
      ""Latitude"": ""40.740893000193296"",
      ""LINE"": ""A-C-E"",
      ""NOTES"": ""A,E-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 445,
      ""NAME"": ""Nostrand Ave"",
      ""Longitude"": ""-73.9504262489579"",
      ""Latitude"": ""40.66993815093054"",
      ""LINE"": ""3-4"",
      ""NOTES"": ""4-nights, 3-all other times"" 
    },
    {
      ""ID"": 446,
      ""NAME"": ""Clark St"",
      ""Longitude"": ""-73.99308599821961"",
      ""Latitude"": ""40.69746599996469"",
      ""LINE"": ""2-3"",
      ""NOTES"": ""2-all times, 3-all times exc nights"" 
    },
    {
      ""ID"": 447,
      ""NAME"": ""Franklin Ave"",
      ""Longitude"": ""-73.95684800014614"",
      ""Latitude"": ""40.68137966658742"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 448,
      ""NAME"": ""Clinton - Washington Aves"",
      ""Longitude"": ""-73.96583799857275"",
      ""Latitude"": ""40.68326299912644"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 449,
      ""NAME"": ""Forest Ave"",
      ""Longitude"": ""-73.90307500005954"",
      ""Latitude"": ""40.70441200087814"",
      ""LINE"": ""M"",
      ""NOTES"": ""M-all times"" 
    },
    {
      ""ID"": 450,
      ""NAME"": ""110th St"",
      ""Longitude"": ""-73.94424999687163"",
      ""Latitude"": ""40.795020000113105"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 451,
      ""NAME"": ""86th St"",
      ""Longitude"": ""-73.95558899985132"",
      ""Latitude"": ""40.77949199820952"",
      ""LINE"": ""4-5-6-6 Express"",
      ""NOTES"": ""4,6-all times, 5-all times exc nights, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 452,
      ""NAME"": ""York St"",
      ""Longitude"": ""-73.98688499993673"",
      ""Latitude"": ""40.699742667691574"",
      ""LINE"": ""F"",
      ""NOTES"": ""F-all times"" 
    },
    {
      ""ID"": 453,
      ""NAME"": ""High St"",
      ""Longitude"": ""-73.99053100065458"",
      ""Latitude"": ""40.69933699977884"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-all times, C-all times exc nights"" 
    },
    {
      ""ID"": 454,
      ""NAME"": ""Lafayette Ave"",
      ""Longitude"": ""-73.97394599849406"",
      ""Latitude"": ""40.68611300020567"",
      ""LINE"": ""A-C"",
      ""NOTES"": ""A-nights, C-all other times"" 
    },
    {
      ""ID"": 455,
      ""NAME"": ""President St"",
      ""Longitude"": ""-73.95058920022207"",
      ""Latitude"": ""40.667883603536815"",
      ""LINE"": ""2-5"",
      ""NOTES"": ""2-all times, 5 weekdays"" 
    },
    {
      ""ID"": 456,
      ""NAME"": ""Woodlawn"",
      ""Longitude"": ""-73.87875099990931"",
      ""Latitude"": ""40.886037000253324"",
      ""LINE"": ""4"",
      ""NOTES"": ""4-all times"" 
    },
    {
      ""ID"": 457,
      ""NAME"": ""Bleecker St"",
      ""Longitude"": ""-73.99465900006331"",
      ""Latitude"": ""40.72591466682659"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays PM"" 
    },
    {
      ""ID"": 458,
      ""NAME"": ""103rd St"",
      ""Longitude"": ""-73.94747800152219"",
      ""Latitude"": ""40.79060000008452"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 459,
      ""NAME"": ""Euclid Ave"",
      ""Longitude"": ""-73.87210600099675"",
      ""Latitude"": ""40.675376998239365"",
      ""LINE"": ""A-C-S"",
      ""NOTES"": ""S to Ozone Park-Lefferts Blvd-nights, C-all other times, A-all times"" 
    },
    {
      ""ID"": 460,
      ""NAME"": ""88th St"",
      ""Longitude"": ""-73.85147000026086"",
      ""Latitude"": ""40.67984300135503"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-all times, S Euclid Av to Ozone Park-Lefferts Blvd-nights"" 
    },
    {
      ""ID"": 461,
      ""NAME"": ""Cortelyou Rd"",
      ""Longitude"": ""-73.96379005505493"",
      ""Latitude"": ""40.6409401651401"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 462,
      ""NAME"": ""116th St"",
      ""Longitude"": ""-73.9416169983714"",
      ""Latitude"": ""40.7986290002001"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 463,
      ""NAME"": ""Parkchester"",
      ""Longitude"": ""-73.86081600108396"",
      ""Latitude"": ""40.83322599927859"",
      ""LINE"": ""6-6 Express"",
      ""NOTES"": ""6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 464,
      ""NAME"": ""Franklin St"",
      ""Longitude"": ""-74.00688600277107"",
      ""Latitude"": ""40.719318001302135"",
      ""LINE"": ""1-2"",
      ""NOTES"": ""1-all times, 2-nights"" 
    },
    {
      ""ID"": 465,
      ""NAME"": ""80th St"",
      ""Longitude"": ""-73.85899200206335"",
      ""Latitude"": ""40.67937100115432"",
      ""LINE"": ""A-S"",
      ""NOTES"": ""A-all times, S Euclid Av to Ozone Park-Lefferts Blvd-nights"" 
    },
    {
      ""ID"": 466,
      ""NAME"": ""5th Ave - Bryant Pk"",
      ""Longitude"": ""-73.98196299856706"",
      ""Latitude"": ""40.75382100064824"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 467,
      ""NAME"": ""Spring St"",
      ""Longitude"": ""-73.99714100006673"",
      ""Latitude"": ""40.72230099999366"",
      ""LINE"": ""4-6-6 Express"",
      ""NOTES"": ""4 nights, 6-all times, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 468,
      ""NAME"": ""125th St"",
      ""Longitude"": ""-73.93759400055725"",
      ""Latitude"": ""40.804138000587244"",
      ""LINE"": ""4-5-6-6 Express"",
      ""NOTES"": ""4,6-all times, 5-all times exc nights, 6 Express-weekdays AM southbound, PM northbound"" 
    },
    {
      ""ID"": 469,
      ""NAME"": ""Coney Island - Stillwell Av"",
      ""Longitude"": ""-73.9812359981396"",
      ""Latitude"": ""40.57728100006751"",
      ""LINE"": ""D-F-N-Q"",
      ""NOTES"": ""D,F,N,Q-all times"" 
    },
    {
      ""ID"": 470,
      ""NAME"": ""34th St - Hudson Yards"",
      ""Longitude"": ""-74.00219709442206"",
      ""Latitude"": ""40.75544635961596"",
      ""LINE"": ""7-7 Express"",
      ""NOTES"": ""7-all times, 7 Express-rush hours AM westbound, PM eastbound"" 
    },
    {
      ""ID"": 641,
      ""NAME"": ""72nd St"",
      ""Longitude"": ""-73.95836178682246"",
      ""Latitude"": ""40.76880251014895"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 642,
      ""NAME"": ""86th St"",
      ""Longitude"": ""-73.95177090964917"",
      ""Latitude"": ""40.77786104333163"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    },
    {
      ""ID"": 643,
      ""NAME"": ""96th St"",
      ""Longitude"": ""-73.9470660219183"",
      ""Latitude"": ""40.784236650177654"",
      ""LINE"": ""Q"",
      ""NOTES"": ""Q-all times"" 
    }
]
";

            #endregion
            var list = JsonConvert.DeserializeObject<List<SubwayStation>>(json);
            return list;
        }
    }
}
