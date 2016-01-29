using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_SubTitles.Core
{
    public class SubtitleModels
    {
        /// <summary>
        /// The subtitle struct used to search the subtitle
        /// </summary>
        public struct subtitleStuct
        {
            public string sublanguageid;
            public string moviehash;
            public double moviebytesize;
        };

        public struct LoginStruct
        {
            public string token;
            public string status;
            public double seconds;
        }

        public struct SearchResult
        {
            public string status;
            public SearchStruct[] data;
        }


        public struct SearchStruct
        {
            //MatchedBy IDSubMovieFile MovieHash MovieByteSize MovieTimeMS IDSubtitleFile SubFileName SubActualCD SubSize SubHash SubLastTS IDSubtitle UserID SubLanguageID SubFormat SubSumCD SubAuthorComment SubAddDate SubBad SubRating SubDownloadsCnt MovieReleaseName MovieFPS IDMovie IDMovieImdb MovieName MovieNameEng MovieYear MovieImdbRating SubFeatured UserNickName ISO639 LanguageName SubComments UserRank SeriesSeason SeriesEpisode MovieKind SubHD SeriesIMDBParent SubEncoding SubDownloadLink ZipDownloadLink SubtitlesLink
            public object MatchedBy;
            public object IDSubMovieFile;
            public object MovieHash;
            public object MovieByteSize;
            public object MovieTimeMS;
            public object IDSubtitleFile;
            public object SubFileName;
            public object SubActualCD;
            public object SubSize;
            public object SubHash;
            public object SubLastTS;
            public object IDSubtitle;
            public object UserID;
            public object SubLanguageID;
            public object SubFormat;
            public object SubSumCD;
            public object SubAuthorComment;
            public object SubAddDate;
            public object SubBad;
            public object SubRating;
            public object SubDownloadsCnt;
            public object MovieReleaseName;
            public object MovieFPS;
            public object IDMovie;
            public object IDMovieImdb;
            public object MovieName;
            public object MovieNameEng;
            public object MovieYear;
            public object MovieImdbRating;
            public object SubFeatured;
            public object UserNickName;
            public object ISO639;
            public object LanguageName;
            public object SubComments;
            public object SubHearingImpaired;
            public object UserRank;
            public object SeriesSeason;
            public object SeriesEpisode;
            public object MovieKind;
            public object SubHD;
            public object SeriesIMDBParent;
            public object SubEncoding;
            public object SubDownloadLink;
            public object ZipDownloadLink;
            public object SubtitlesLink;
        }
    }
}
