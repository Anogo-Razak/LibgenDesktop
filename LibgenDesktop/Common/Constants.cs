﻿using System;

namespace LibgenDesktop.Common
{
    internal static class Constants
    {
        public const string CURRENT_VERSION = "1.0";
        public const string CURRENT_GITHUB_RELEASE_NAME = "1.0";
        public static readonly DateTime CURRENT_GITHUB_RELEASE_DATE = new DateTime(2018, 3, 15);
        public const string CURRENT_DATABASE_VERSION = "1.0";

        public const string APP_SETTINGS_FILE_NAME = "libgen.config";
        public const string MIRRORS_DIRECTORY_NAME = "Mirrors";
        public const string MIRRORS_FILE_NAME = "mirrors.config";
        public const string LANGUAGES_DIRECTORY_NAME = "Languages";
        public const string DEFAULT_LANGUAGE_NAME = "English";
        public const string DEFAULT_DOWNLOAD_DIRECTORY_NAME = "Downloads";
        public const string DOWNLOAD_LIST_FILE_NAME = "downloads.json";

        public const int MAIN_WINDOW_MIN_WIDTH = 1050;
        public const int MAIN_WINDOW_MIN_HEIGHT = 500;
        public const int NON_FICTION_DETAILS_WINDOW_MIN_WIDTH = 1000;
        public const int NON_FICTION_DETAILS_WINDOW_MIN_HEIGHT = 500;
        public const int NON_FICTION_GRID_TITLE_COLUMN_MIN_WIDTH = 150;
        public const int NON_FICTION_GRID_AUTHORS_COLUMN_MIN_WIDTH = 150;
        public const int NON_FICTION_GRID_SERIES_COLUMN_MIN_WIDTH = 150;
        public const int NON_FICTION_GRID_YEAR_COLUMN_MIN_WIDTH = 60;
        public const int NON_FICTION_GRID_PUBLISHER_COLUMN_MIN_WIDTH = 150;
        public const int NON_FICTION_GRID_FORMAT_COLUMN_MIN_WIDTH = 80;
        public const int NON_FICTION_GRID_FILESIZE_COLUMN_MIN_WIDTH = 130;
        public const int NON_FICTION_GRID_OCR_COLUMN_MIN_WIDTH = 55;
        public const int FICTION_DETAILS_WINDOW_MIN_WIDTH = 600;
        public const int FICTION_DETAILS_WINDOW_MIN_HEIGHT = 500;
        public const int FICTION_GRID_TITLE_COLUMN_MIN_WIDTH = 150;
        public const int FICTION_GRID_AUTHORS_COLUMN_MIN_WIDTH = 150;
        public const int FICTION_GRID_SERIES_COLUMN_MIN_WIDTH = 150;
        public const int FICTION_GRID_YEAR_COLUMN_MIN_WIDTH = 60;
        public const int FICTION_GRID_PUBLISHER_COLUMN_MIN_WIDTH = 150;
        public const int FICTION_GRID_FORMAT_COLUMN_MIN_WIDTH = 80;
        public const int FICTION_GRID_FILESIZE_COLUMN_MIN_WIDTH = 130;
        public const int SCI_MAG_DETAILS_WINDOW_MIN_WIDTH = 600;
        public const int SCI_MAG_DETAILS_WINDOW_MIN_HEIGHT = 500;
        public const int SCI_MAG_GRID_TITLE_COLUMN_MIN_WIDTH = 150;
        public const int SCI_MAG_GRID_AUTHORS_COLUMN_MIN_WIDTH = 150;
        public const int SCI_MAG_GRID_JOURNAL_COLUMN_MIN_WIDTH = 100;
        public const int SCI_MAG_GRID_YEAR_COLUMN_MIN_WIDTH = 60;
        public const int SCI_MAG_GRID_FILESIZE_COLUMN_MIN_WIDTH = 130;
        public const int SCI_MAG_GRID_DOI_COLUMN_MIN_WIDTH = 150;
        public const int DOWNLOAD_MANAGER_TAB_DOWNLOADS_PANEL_MIN_HEIGHT = 100;
        public const int DOWNLOAD_MANAGER_TAB_LOG_PANEL_MIN_HEIGHT = 50;
        public const int DOWNLOAD_MANAGER_TAB_LOG_PANEL_DEFAULT_HEIGHT = 150;
        public const int ERROR_WINDOW_DEFAULT_WIDTH = 620;
        public const int ERROR_WINDOW_DEFAULT_HEIGHT = 450;
        public const int ERROR_WINDOW_MIN_WIDTH = 400;
        public const int ERROR_WINDOW_MIN_HEIGHT = 300;
        public const int IMPORT_WINDOW_MIN_WIDTH = 530;
        public const int IMPORT_WINDOW_MIN_HEIGHT = 400;
        public const int CREATE_DATABASE_WINDOW_WIDTH = 500;
        public const int SETTINGS_WINDOW_DEFAULT_WIDTH = 760;
        public const int SETTINGS_WINDOW_DEFAULT_HEIGHT = 550;
        public const int SETTINGS_WINDOW_MIN_WIDTH = 760;
        public const int SETTINGS_WINDOW_MIN_HEIGHT = 550;
        public const int SYNCHRONIZATION_WINDOW_MIN_WIDTH = 530;
        public const int SYNCHRONIZATION_WINDOW_MIN_HEIGHT = 400;
        public const int APPLICATION_UPDATE_WINDOW_WIDTH = 700;
        public const int DATABASE_WINDOW_WIDTH = 500;
        public const int ABOUT_WINDOW_WIDTH = 670;
        public const int MESSAGE_BOX_WINDOW_WIDTH = 500;

        public const string DEFAULT_DATABASE_FILE_NAME = "libgen.db";
        public const int DEFAULT_MAIN_WINDOW_WIDTH = 1050;
        public const int DEFAULT_MAIN_WINDOW_HEIGHT = 650;
        public const int DEFAULT_NON_FICTION_DETAILS_WINDOW_WIDTH = 1200;
        public const int DEFAULT_NON_FICTION_DETAILS_WINDOW_HEIGHT = 618;
        public const int DEFAULT_NON_FICTION_GRID_TITLE_COLUMN_WIDTH = 200;
        public const int DEFAULT_NON_FICTION_GRID_AUTHORS_COLUMN_WIDTH = 200;
        public const int DEFAULT_NON_FICTION_GRID_SERIES_COLUMN_WIDTH = 180;
        public const int DEFAULT_NON_FICTION_GRID_YEAR_COLUMN_WIDTH = 60;
        public const int DEFAULT_NON_FICTION_GRID_PUBLISHER_COLUMN_WIDTH = 180;
        public const int DEFAULT_NON_FICTION_GRID_FORMAT_COLUMN_WIDTH = 100;
        public const int DEFAULT_NON_FICTION_GRID_FILESIZE_COLUMN_WIDTH = 150;
        public const int DEFAULT_NON_FICTION_GRID_OCR_COLUMN_WIDTH = 55;
        public const int DEFAULT_FICTION_DETAILS_WINDOW_WIDTH = 850;
        public const int DEFAULT_FICTION_DETAILS_WINDOW_HEIGHT = 650;
        public const int DEFAULT_FICTION_GRID_TITLE_COLUMN_WIDTH = 200;
        public const int DEFAULT_FICTION_GRID_AUTHORS_COLUMN_WIDTH = 200;
        public const int DEFAULT_FICTION_GRID_SERIES_COLUMN_WIDTH = 180;
        public const int DEFAULT_FICTION_GRID_YEAR_COLUMN_WIDTH = 60;
        public const int DEFAULT_FICTION_GRID_PUBLISHER_COLUMN_WIDTH = 180;
        public const int DEFAULT_FICTION_GRID_FORMAT_COLUMN_WIDTH = 100;
        public const int DEFAULT_FICTION_GRID_FILESIZE_COLUMN_WIDTH = 150;
        public const int DEFAULT_SCI_MAG_DETAILS_WINDOW_WIDTH = 910;
        public const int DEFAULT_SCI_MAG_DETAILS_WINDOW_HEIGHT = 680;
        public const int DEFAULT_SCI_MAG_GRID_TITLE_COLUMN_WIDTH = 270;
        public const int DEFAULT_SCI_MAG_GRID_AUTHORS_COLUMN_WIDTH = 200;
        public const int DEFAULT_SCI_MAG_GRID_JOURNAL_COLUMN_WIDTH = 120;
        public const int DEFAULT_SCI_MAG_GRID_YEAR_COLUMN_WIDTH = 60;
        public const int DEFAULT_SCI_MAG_GRID_FILESIZE_COLUMN_WIDTH = 150;
        public const int DEFAULT_SCI_MAG_GRID_DOI_COLUMN_WIDTH = 290;
        public const string DEFAULT_MIRROR_NAME = "libgen.io";
        public const int DEFAULT_MAXIMUM_SEARCH_RESULT_COUNT = 50000;

        public const double SEARCH_PROGRESS_REPORT_INTERVAL = 0.1;
        public const double IMPORT_PROGRESS_UPDATE_INTERVAL = 0.5;
        public const double SYNCHRONIZATION_PROGRESS_UPDATE_INTERVAL = 0.1;
        public const int DATABASE_TRANSACTION_BATCH = 500;
        public const int MAX_EXPORT_ROWS_PER_FILE = 1048575;
        public const int MIN_DOWNLOAD_TIMEOUT = 15;
        public const int MAX_DOWNLOAD_TIMEOUT = 9999;
        public const int DEFAULT_DOWNLOAD_TIMEOUT = 120;
        public const int MAX_DOWNLOAD_ATTEMPT_COUNT = 99;
        public const int DEFAULT_DOWNLOAD_ATTEMPT_COUNT = 3;
        public const int MAX_DOWNLOAD_RETRY_DELAY = 9999;
        public const int DEFAULT_DOWNLOAD_RETRY_DELAY = 60;
        public const int MAX_DOWNLOAD_REDIRECT_COUNT = 10;

        public const string GITHUB_RELEASE_API_URL = "https://api.github.com/repos/libgenapps/LibgenDesktop/releases";
        public const string USER_AGENT = "LibgenDesktop/" + CURRENT_VERSION;
        public const int MIN_PROXY_PORT = 1;
        public const int MAX_PROXY_PORT = 65535;
    }
}
