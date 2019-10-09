FUNCTION doc_hist_delai
LPARAMETERS le_jou,le_delai
DATE_1=DATE()-m.le_delai
DATE_2=DATE()-m.le_delai
DO yHistoricDoc WITH m.le_jou
ENDFUNC
