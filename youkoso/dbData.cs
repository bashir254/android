﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace youkoso;

        public class dbData
        {
public static string db_data = "あ	ア	が	ガ	きゃ	キャ	1	1	きせつ　季節	こんにちは	わたし　私	ちち　父	からだ　体\r\n" + 
"a	a	ga	ga	kya	kya	1	ichi	موسم أو مواسم	أهلا	أنا, ضمير المتكلم	الأب	جسم الإنسان\r\n" + 
"い	イ	ぎ	ギ	きゅ	キュ	2	2	しき　四季	ようこそ	あなた	はは　母	きかん　器官\r\n" + 
"i	i	gi	gi	kyu	kyu	2	ni	الفصول السنوية الأربعة	مرحبا	أنت, ضمير المخاطب	الأم	أعضاء الجسم\r\n" + 
"う	ウ	ぐ	グ	きょ	キョ	3	3	はる　春	いらしゃいませ	わたしたち　私たち	おとうさん　お父さん	ひふ　皮膚\r\n" + 
"u	u	gu	gu	kyo	kyo	3	san	الربيع	مرحبا	ضمير المتكلم, للمثنى والجمع	الأب	الجلد\r\n" + 
"え	エ	げ	ゲ	ぎゃ	ギャ	4	4	なつ　夏	おはようございます	あなたたち	おかあさん　お母さん	にく　肉\r\n" + 
"e	e	ge	ge	gya	gya	4	yon	الصيف	صباح الخير	ضمير المخاطب, للمثنى والجمع	الأم	اللحم\r\n" + 
"お	オ	ご	ゴ	ぎゅ	ギュ	5	5	あき　秋	こんばんは	かれ　彼	むすこ　息子	きんにく　筋肉\r\n" + 
"o	o	go	go	gyu	gyu	5	go	الخريف	مساء الخير	ضمير المذكر الغائب, هو	الإبن	العضلات\r\n" + 
"か	カ	ざ	ザ	ぎょ	ギョ	6	6	ふゆ　冬	おやすみなさい	かのじょ　彼女	むすめ　娘	ほね　骨\r\n" + 
"ka	ka	za	za	gyo	gyo	6	roku	الشتاء	طاب مساؤك	ضمير المؤنث الغائب, هي	الإبنة	العظام\r\n" + 
"き	キ	じ	ジ	しゃ	シャ	7	7	こよみ　暦	ただいま	かれらたち　彼らたち	まご　孫	あたま　頭\r\n" + 
"ki	ki	zi	zi	sha	sha	7	nana	التقويم القمري	لقد عدت	ضمير المذكر الغائب, للمثنى والجمع	الأحفاد	الرأس\r\n" + 
"く	ク	ず	ズ	しゅ	シュ	8	8	せいれき　西暦	おかえりなさい	かのじょたち　彼女たち	こども　子供	かみのけ　髪の毛\r\n" + 
"ku	ku	zu	zu	shu	shu	8	hachi	التقويم الميلادي	مرحبا بعودتك	ضمير المؤنث الغائب, للمثنى والجمع	الأبناء	شعر الرأس\r\n" + 
"け	ケ	ぜ	ゼ	しょ	ショ	9	9	せいき　世紀	ありがとうございます		きょうだい　兄弟	かお　顔\r\n" + 
"ke	ke	ze	ze	sho	sho	9	kyu	قرن	شكرا		الأخوة	الوجه\r\n" + 
"こ	コ	ぞ	ゾ	じゃ	ジャ	10	10	ねん أو とし　年			おにいさん　お兄さん	おでっこ\r\n" + 
"ko	ko	zo	zo	ja	ja	10	juu	سنة			الأخ الأكبر	الجبين\r\n" + 
"さ	サ	だ	ダ	じゅ	ジュ	11	11	２０００ねん　2000年			おねえさん　お姉さん	め　眼\r\n" + 
"sa	sa	da	da	ju	ju	11	juu ichi	سنة 2000			الأخت الأكبر	العين\r\n" + 
"し	シ	ぢ	ヂ	じょ	ジョ	12	20	つき　月			おとうと　弟	みみ　耳\r\n" + 
"shi	shi	ji	ji	jo	jo	12	ni juu	شهر			الأخ الأصغر	الأذن\r\n" + 
"す	ス	づ	ヅ	ちゃ	チャ	13	30	１がつ　１月			いもうと　妹	はな　鼻\r\n" + 
"su	su	zu	zu	cha	cha	13	san juu	شهر واحد			الأخت الصغرى	الأنف\r\n" + 
"せ	セ	で	デ	ちゅ	チュ	14	40	しゅう　週			おじさん　叔父さん	くち　口\r\n" + 
"se	se	de	de	chu	chu	14	yon juu	أسبوع			العم والخال	الفم\r\n" + 
"そ	ソ	ど	ド	ちょ	チョ	15	50	ひにち　日にち			おばさん　叔母さん	くちびる　唇\r\n" + 
"so	so	do	do	cho	cho	15	go juu	يوم			العمة والخالة	الشفتين\r\n" + 
"た	タ	ば	バ	にゃ	ニャ	16	60	きょう　今日			おじいさん　お祖父さん	は　歯\r\n" + 
"ta	ta	ba	ba	nya	nya	16	roku juu	اليوم			الجد أو الرجل الكبير	الأسنان\r\n" + 
"ち	チ	び	ビ	にゅ	ニュ	17	70	あした　明日			おばあさん　お祖母さん	した　舌\r\n" + 
"chi	chi	bi	bi	nyu	nyu	17	nana juu	الغد			الجدة أو المرأة الكبيرة	اللسان\r\n" + 
"つ	ツ	ぶ	ブ	にょ	ニョ	18	80	あさって　明後日			そふ　祖父	あご　顎\r\n" + 
"tsu	tsu	bu	bu	nyo	nyo	18	hachi juu	بعد بكرة			الجد	الذقن\r\n" + 
"て	テ	べ	ベ	ひゃ	ヒャ	19	90	きのう　昨日			そぼ　祖母	くちひげ　口ひげ\r\n" + 
"te	te	be	be	hya	hya	19	kyu juu	أمس			الجدة	الشارب\r\n" + 
"と	ト	ぼ	ボ	ひゅ	ヒュ	20	100	１さくじつ　一昨日			おいこ　甥子	ほほ　頬\r\n" + 
"to	to	bo	bo	hyu	hyu	20	hyaku	أول أمس			إبن الأخ والأخت	الخد\r\n" + 
"な	ナ	ぱ	パ	ひょ	ヒョ	21	101	ことし　今年			めいこ　姪子	くび　首\r\n" + 
"na	na	pa	pa	hyo	hyo	21	hyaku ichi	السنة الحالية			بنت الأخ والأخت	العنق\r\n" + 
"に	ニ	ぴ	ピ	びゃ	ビャ	22	110	こんげつ　今月			いとこ　従兄弟	かた　肩\r\n" + 
"ni	ni	pi	pi	bya	bya	22	hyaku juu	اشهر الحالي			أبناء وبنات الأعمام والأخوال	الكتف\r\n" + 
"ぬ	ヌ	ぷ	プ	びゅ	ビュ	23	111	こんしゅう　今週			おとこ　男	むね　胸\r\n" + 
"nu	nu	pu	pu	byu	byu	23	hyaku juu ichi	الأسبوع الحالي			ولد	الصدر\r\n" + 
"ね	ネ	ぺ	ペ	びょ	ビョ	24	200	どようび　土曜日			おんな　女	せなか　背中\r\n" + 
"ne	ne	pe	pe	byo	byo	24	ni hyaku	يوم السبت			بنت	الظهر\r\n" + 
"の	ノ	ぽ	ポ	ぴゃ	ピャ	25	300	にちようび　日曜日			かぞく　家族	おなか　お腹\r\n" + 
"no	no	po	po	pya	pya	25	san byaku	يوم الأحد			الأسرة	البطن\r\n" + 
"は	ハ			ぴゅ	ピュ	26	400	げつようび　月曜日				しし　四肢\r\n" + 
"ha	ha			pyu	pyu	26	yon hyaku	يوم الإثنين				الأطراف الأربعة\r\n" + 
"ひ	ヒ			ぴょ	ピョ	27	500	かようび　火曜日				じょうし　上肢\r\n" + 
"hi	hi			pyo	pyo	27	go hyaku	يوم الثلاثاء				الأطراف العلوية\r\n" + 
"ふ	フ			みゃ	ミャ	28	600	すいようび　水曜日				かし　下肢\r\n" + 
"hu	hu			mya	mya	28	robbyaku	يوم الأربعاء				الأطراف السفلى\r\n" + 
"へ	ヘ			みゅ	ミュ	29	700	もくようび　木曜日				て　手\r\n" + 
"he	he			my	my	29	nana hyaku	يوم الخميس				اليد\r\n" + 
"ほ	ホ			みょ	ミョ	30	800	きんようび　金曜日				あし　足\r\n" + 
"ho	ho			myo	myo	30	habbyaku	يوم الجمعة				القدم\r\n" + 
"ま	マ			りゃ	リャ	31	900	じ　とき　時				ゆび　指\r\n" + 
"ma	ma			rya	rya	31	kyu hyaku	وقت زمن				الأصابع\r\n" + 
"み	ミ			りゅ	リュ	32	1000	１じ　１時				つめ　爪\r\n" + 
"mi	mi			ryu	ryu	32	sen	الساعة الواحدة				الظفور\r\n" + 
"む	ム			りょ	リョ	33	1001	じかん　時間				うで腕\r\n" + 
"mu	mu			ryo	ryo	33	sen ichi	ساعة من الزمن				ذراع\r\n" + 
"め	メ					34	1111	ぶん　分				のう　脳\r\n" + 
"me	me					34	sen hyaku juu ichi	دقيقة				الدماغ\r\n" + 
"も	モ					35	2000	びょう　秒				しんぞう　心臓\r\n" + 
"mo	mo					35	ni sen	ثانية				القلب\r\n" + 
"や	ヤ					36	3000	よあけ　夜明け				はい　肺\r\n" + 
"ya	ya					36	san zen	الفجر				الرئة\r\n" + 
"（い）	（イ）					37	4000	そうちょう　早朝				い　胃\r\n" + 
"(i)	(i)					37	yon sen	الصباح الباكر				المعدة\r\n" + 
"ゆ	ユ					38	5000	ひので　日の出				かんぞう　肝臓\r\n" + 
"yu	yu					38	go sen	الشروق				الكبد\r\n" + 
"（え）	（エ）					39	6000	ひるま　昼間				じんぞう　腎臓\r\n" + 
"(e)	(e)					39	roku sen	فترة الزهيرة				الكلى\r\n" + 
"よ	ヨ					40	7000	しょうご　正午				けつえき　血液\r\n" + 
"yo	yo					40	nana sen	منتصف النهار				الدم\r\n" + 
"ら	ラ					41	8000	ごぜん　午前				どうみゃく　動脈\r\n" + 
"ra	ra					41	hassen	صباحا				الشرايين\r\n" + 
"り	リ					42	9000	ごご　午後				じょうみゃく　静脈\r\n" + 
"ri	ri					42	kyu sen	مساءا				الأوردة\r\n" + 
"る	ル					43	10000	ゆうがた　夕方				けっかん　血管\r\n" + 
"ru	ru					43	ichi man	أول الليل				الأوعية الدموية\r\n" + 
"れ	レ					44	10001	にちぼつ　日没				\r\n" + 
"re	re					44	ichi man ichi	الغروب				\r\n" + 
"ろ	ロ					45	11111	よる　夜				\r\n" + 
"ro	ro					45	ichi man sen hyaku juu ichi	المساء				\r\n" + 
"わ	ワ					46	20000	まよなか　真夜中				\r\n" + 
"wa	wa					46	ni man	منتصف الليل				\r\n" + 
"を	ヲ					47	1000000	いま　今				\r\n" + 
"o	o					47	hyaku man	الآن				\r\n" + 
"ん	ン					48		らいねん　来年				\r\n" + 
"n	n					48		العام القادم				\r\n" + 
"						49		らいげつ　来月				\r\n" + 
"						49		الشهر القادم				\r\n" + 
"						50		らいしゅう　来週				\r\n" + 
"						50		الأسبوع القادم				\r\n" + 
"						51		きょねん　去年				\r\n" + 
"						51		السنة الماضية				\r\n" + 
"						52		せんげつ　先月				\r\n" + 
"						52		الشهر السابق				\r\n" + 
"						53		せんしゅう　先週				\r\n" + 
"						53		الأسبوع السابق				";

}