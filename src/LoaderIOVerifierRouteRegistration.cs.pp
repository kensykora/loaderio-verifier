using System;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: WebActivatorEx.PreApplicationStartMethod(
    typeof($rootnamespace$.App_Start.LoaderIOVerifierRouteRegistration), "PreStart")]

namespace $rootnamespace$.App_Start {
    public static class LoaderIOVerifierRouteRegistration {
        public static void PreStart() {
            RouteTable.Routes.IgnoreRoute("loaderio-{key}.txt");
        }
    }
}