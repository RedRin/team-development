using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using team_development.UI.CourseSelection;
using team_development.UI.UserInfo;
using team_development.UI.Absence;
using team_development.UI.QueryMealCard;
using team_development.UI.QueryEmploy;
using team_development.UI.QueryInform;
using team_development.UI.QueryElectricity;
using team_development.UI.MatchScheme;
using team_development.UI.QueryGPA;
using team_development.UI.Search;
using Lib;
using System.Net;
using team_development.UI.Forum;

namespace team_development.FormLib
{
    public enum MenuType { JWXT, Absence, Forum, Query, UserInfo, Search,Nothing };
    public enum SubMenuType { CourseSelection,MatchScheme,QueryMark,QueryInform,QueryEmploy,QueryMealCard,QueryCost }
    public class MenuGetter
    {
        public static Form CourseSelectionInstance, MatchSchemeInstance, QueryMarkInstance,
            QueryInformInstance, QueryEmployInstance, QueryMealCardInstance, QueryCostInstance, SearchInstance, AbsenceInstance, QueryInstance, UserInfoInstance, ForumInstance;
        static MenuGetter() {
            CourseSelectionInstance = new CourseSelection();
            MatchSchemeInstance = new MatchScheme();
            QueryMarkInstance = new QueryMark();
            QueryInformInstance = new QueryNotification();
            QueryEmployInstance = new QueryEmploy();
            QueryMealCardInstance = new QueryMealcard();
            QueryCostInstance = new QueryElectricity();
            SearchInstance = new Search();
            AbsenceInstance = new AbsenceInput(); 
            UserInfoInstance= new UserInfoDisplay();
            ForumInstance = new Forum();
        }
        public static void Init() { }
        public static Form GetMenu(MenuType MenuId,SubMenuType SubMenuId=0) {
            Log.log.Info("Require Turn From");
            switch (MenuId) {
                case MenuType.JWXT:
                    switch (SubMenuId) {
                        case SubMenuType.CourseSelection:
                            return CourseSelectionInstance;
                            break;
                        case SubMenuType.MatchScheme:
                            return MatchSchemeInstance;
                            break;
                        default:break;
                    }
                    break;
                case MenuType.Absence:
                    return AbsenceInstance;
                    break;
                case MenuType.Forum:
                    return ForumInstance;
                    break;
                case MenuType.Query:
                    switch (SubMenuId) {
                        case SubMenuType.QueryMark:
                            return QueryMarkInstance;
                            break;
                        case SubMenuType.QueryInform:
                            return QueryInformInstance;
                            break;
                        case SubMenuType.QueryEmploy:
                            return QueryEmployInstance;
                            break;
                        case SubMenuType.QueryMealCard:
                            return QueryMealCardInstance;
                            break;
                        case SubMenuType.QueryCost:
                            return QueryCostInstance;
                            break;
                        default:
                            Log.log.Error("ERROR Menu!!!");
                            //error processing
                            break;
                    }
                    break;
                case MenuType.Search:
                    return SearchInstance;
                    break;
                case MenuType.UserInfo:
                    return UserInfoInstance;
                    break;
                case MenuType.Nothing:
                    return null;
                    break;
                default:
                    Log.log.Error("ERROR SubMenu!!!");
                    break;
            }
            return null;
        }

    }
   
}
